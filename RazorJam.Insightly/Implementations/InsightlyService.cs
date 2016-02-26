/*
 * Razor Jam (razorjam.co.uk)
 *
 * Author:
 *  Elliot Chaim (elliot.chaim@razorjam.co.uk)
 *  
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace RazorJam.Insightly.Implementations
{
   using System;
   using System.Collections.Generic;
   using System.Configuration;
   using System.Net.Http;
   using System.Runtime.Caching;
   using System.Threading.Tasks;
   using Flurl.Http;

   public class InsightlyService: IInsightlyService, IInsightlyServiceWithResource
   {
      private const string InsightlyUri = "https://api.insight.ly/v2.1/";
      private string ApiKey => ConfigurationManager.AppSettings[ "Insightly.apiKey" ];
      private readonly ObjectCache cache;
      private CacheItemPolicy StandardPolicy()
      {
         return new CacheItemPolicy() { AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(10) };
      }
      private string Resource { get; set; }

      public InsightlyService()
      {
         cache = MemoryCache.Default;
      }

      public IInsightlyServiceWithResource With( string resource )
      {
         this.Resource = resource;
         return this;
      }

      public IInsightlyResponse<IEnumerable<IInsightlyObject>> GetAll<IInsightlyObject>()
      {
         return GetRequestCached<IEnumerable<IInsightlyObject>>( this.Resource );
      }

      public IInsightlyResponse<IInsightlyObject> Create( IInsightlyObject data )
      {
         if( data == null )
            throw new ArgumentNullException(nameof(data));
         var response = DoRequest<IInsightlyObject>(this.Resource, "POST", data).Result;
         if( response.ResponseStatus() == 200 )
            cache.Remove( this.Resource );
         return response;
      }

      public IInsightlyResponse<IInsightlyObject> Get<IInsightlyObject>( int id )
      {
         return GetRequestCached<IInsightlyObject>(this.Resource + id.ToString());
      }

      public IInsightlyResponse<IInsightlyObject> Update<IInsightlyObject>( IInsightlyObject data )
      {
         if( data == null )
            throw new ArgumentNullException(nameof(data));
         var response = DoRequest<IInsightlyObject>(this.Resource, "PUT", data).Result;
         if( response.ResponseStatus() == 200 )
         {
            //cache.Set( this.Resource + response.ResponseData().Id(), response, StandardPolicy() );
            cache.Remove(this.Resource);
         }
         return response;
      }

      public IInsightlyResponse<bool> Delete(int id)
      {
         var response = DoRequest<bool>( this.Resource + id.ToString(), "DELETE", null ).Result;
         if( response.ResponseStatus() == 202 )
            cache.Remove(this.Resource + id.ToString());
         return response;
      }

      public IInsightlyResponse<T> GetRequestCached<T>( string url )
      {
         if( cache[ url ] == null )
         {
            cache.Set(url, DoRequest<T>(url, "GET", null).Result, StandardPolicy());
         }
         return (IInsightlyResponse<T>) cache[ url ];
      }

      public async Task<IInsightlyResponse<T>> DoRequest<T>( string url, string method, object body )
      {
         IInsightlyResponse<T> result;
         try
         {
            var request = Authorise(url);
            Task<HttpResponseMessage> response;
            T responseData;
            switch( method.ToLower() )
            {
               case "post":
                  if( body == null )
                     throw new ArgumentNullException(nameof(body));
                  response = request.PostJsonAsync( body );
                  responseData = await response.ReceiveJson<T>().ConfigureAwait(false);
                  break;
               case "get":
                   response = request.GetAsync();
                   responseData = await response.ReceiveJson<T>().ConfigureAwait( false );
                  break;
               case "put":
                  if( body == null )
                     throw new ArgumentNullException(nameof(body));
                  response = request.PutJsonAsync( body );
                  responseData = await response.ReceiveJson<T>().ConfigureAwait( false );
                  break;
               case "delete":
                  response = request.DeleteAsync();
                  responseData = default(T);
                  await response.ConfigureAwait(false);
                  break;
               default:
                  throw new ArgumentException(nameof(method));
            }
            result = new InsightlyResponse<T>((int) response.Result.StatusCode, responseData);
         }
         catch
         {
            result = new InsightlyResponse<T>( 500, default(T) );
         }
         return result;
      }

      public FlurlClient Authorise( string path )
      {
         var request = InsightlyUri + path;
         return request.WithBasicAuth(ApiKey, "");
      }
   }
}