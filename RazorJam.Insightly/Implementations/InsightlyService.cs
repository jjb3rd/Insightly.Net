/*
 * Started by Beckersoft, Inc.
 * Extended by Razor Jam (razorjam.co.uk)
 *
 * Author(s):
 *  John Becker (john@beckersoft.com)
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
   using System.Runtime.Caching;
   using System.Threading.Tasks;
   using Flurl.Http;

   public class InsightlyService : IInsightlyService
   {
      private string _apiUri = "https://api.insight.ly/v2.1/";
      private string ApiKey { get; }
      private readonly ObjectCache cache;
      private CacheItemPolicy StandardPolicy()
      {
         return new CacheItemPolicy() {AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(10)};
      }
      private string Resource { get; set; }

      public InsightlyService(string key)
      {
         ApiKey = key;
         cache = MemoryCache.Default;
      }

      public IInsightlyService With(string resource)
      {
         this.Resource = resource;
         return this;
      }

      public IEnumerable<IInsightlyObject> GetAll<IInsightlyObject>()
      {
         return GetRequestCached<IEnumerable<IInsightlyObject>>(this.Resource) as IEnumerable<IInsightlyObject>;
      }

      public IInsightlyObject Create(IInsightlyObject data)
      {
         if (data == null)
            throw new ArgumentNullException(nameof(data));
         cache.Remove("Contacts");
         return DoRequest<IInsightlyObject>(this.Resource, "POST", data).Result;
      }

      public IInsightlyObject Get<IInsightlyObject>(int id)
      {
         return (IInsightlyObject) GetRequestCached<IInsightlyObject>(this.Resource + id.ToString());
      }

      // TODO: fix caching issue
      // TODO: use, and test
      public IInsightlyObject Update<IInsightlyObject>(IInsightlyObject data)
      {
         throw new NotImplementedException();
         if (data == null)
            throw new ArgumentNullException(nameof(data));

         var response = DoRequest<IInsightlyObject>(this.Resource, "PUT", data).Result;
         if (response == null)
            return default(IInsightlyObject);

         //cache.Set("Contacts/" + response.Id, response, StandardPolicy());
         cache.Remove("Contacts");

         return response;
      }

      // TODO: implement, use, and test
      public bool Delete()
      {
         throw new NotImplementedException();
      }

      public object GetRequestCached<T>( string url )
      {
         if( cache[ url ] == null )
         {
            cache.Set(url, DoRequest<T>(url, "GET", null).Result, StandardPolicy());
         }
         return cache[ url ];
      }

      public async Task<T> DoRequest<T>( string url, string method, object body )
      {
         var request = Authorise(url);
         var response = default(T);
         try
         {
            switch( method.ToLower() )
            {
               case "post":
                  if( body == null )
                     throw new ArgumentNullException(nameof(body));
                  response = await request.PostJsonAsync(body).ReceiveJson<T>().ConfigureAwait(false);
                  break;
               case "get":
                  response = await request.GetJsonAsync<T>().ConfigureAwait(false);
                  break;
               case "put":
                  if( body == null )
                     throw new ArgumentNullException(nameof(body));
                  response = await request.PutJsonAsync(body).ReceiveJson<T>().ConfigureAwait(false);
                  break;
            }
         }
         catch
         {
         }
         return response;
      }

      public FlurlClient Authorise( string path )
      {
         var request = _apiUri + path;
         return request.WithBasicAuth(ApiKey, "");
      }
   }
}