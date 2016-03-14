namespace RazorJam.Insightly.Implementations
{
   using System;
   using System.Collections.Generic;
   using System.Configuration;
   using System.Net.Http;
   using System.Runtime.Caching;
   using System.Threading.Tasks;
   using Flurl.Http;
   using RazorJam.Insightly.Infrastructure;

   public class InsightlyService : IInsightlyService
   {
      //private readonly ObjectCache cache;
      //private CacheItemPolicy StandardPolicy()
      //{
      //   return new CacheItemPolicy() { AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(10) };
      //}

      //public InsightlyService()
      //{
      //   cache = MemoryCache.Default;
      //}

      public IInsightlyServiceWithResource<T> With<T>(bool beta = false)
         where T : IInsightlyObject
      {
         var uri = beta ? "https://api.insight.ly/v2.2/" : "https://api.insight.ly/v2.1/";
         return new InsightlyServiceWithResource<T>()
         {
            Resource = Resources.Get<T>(),
            InsightlyUri = uri
         };
      }
   }

   public class InsightlyServiceWithResource<T> : IInsightlyServiceWithResource<T>
      where T : IInsightlyObject
   {
      private string ApiKey = ConfigurationManager.AppSettings["Insightly.apiKey"];

      public string InsightlyUri = "https://api.insight.ly/v2.1/";
      public string Resource { get; set; }

      //public IInsightlyResponse<T> GetRequestCached<T>( string url )
      //{
      //   if( cache[ url ] == null )
      //   {
      //      cache.Set(url, DoRequest<T>(url, "GET", null).Result, StandardPolicy());
      //   }
      //   return (IInsightlyResponse<T>) cache[ url ];
      //}
      private IInsightlyResponse<TOut> Get<TOut>(string id = "")
      {
         return DoRequest<TOut>(this.Resource + id, "GET", null).Result;//GetRequestCached<IInsightlyObject>(this.Resource + id);
      }

      public IInsightlyResponse<IEnumerable<T>> GetAll()
      {
         return Get<IEnumerable<T>>();
      }

      public IInsightlyResponse<T> Get(int id)
      {
         return Get<T>(id.ToString());
      }
      
      public IInsightlyResponse<T> Create(T data)
      {
         if (data == null)
            throw new ArgumentNullException("data");
         var response = DoRequest<T>(this.Resource, "POST", data).Result;
         //if (response.ResponseStatus() == 200)
         //   cache.Remove(this.Resource);
         return response;
      }
      
      public IInsightlyResponse<T> Update(T data)
      {
         if (data == null)
            throw new ArgumentNullException("data");
         var response = DoRequest<T>(this.Resource, "PUT", data).Result;
         //if (response.ResponseStatus() == 200)
         //{
         //   cache.Set( this.Resource + response.ResponseData().Id(), response, StandardPolicy() );
         //   cache.Remove(this.Resource);
         //}
         return response;
      }

      public IInsightlyResponse<bool> Delete(int id)
      {
         var response = DoRequest<bool>(this.Resource + id.ToString(), "DELETE", null).Result;
         //if (response.ResponseStatus() == 202)
         //   cache.Remove(this.Resource + id.ToString());
         return response;
      }

      public async Task<IInsightlyResponse<T>> DoRequest<T>(string url, string method, object body)
      {
         IInsightlyResponse<T> result;
         try
         {
            var request = Authorise(url);
            Task<HttpResponseMessage> response;
            T responseData;
            switch (method.ToLower())
            {
               case "post":
                  if (body == null)
                     throw new ArgumentNullException("body");
                  response = request.PostJsonAsync(body);
                  responseData = await response.ReceiveJson<T>().ConfigureAwait(false);
                  break;
               case "get":
                  response = request.GetAsync();
                  responseData = await response.ReceiveJson<T>().ConfigureAwait(false);
                  break;
               case "put":
                  if (body == null)
                     throw new ArgumentNullException("body");
                  response = request.PutJsonAsync(body);
                  responseData = await response.ReceiveJson<T>().ConfigureAwait(false);
                  break;
               case "delete":
                  response = request.DeleteAsync();
                  responseData = default(T);
                  await response.ConfigureAwait(false);
                  break;
               default:
                  throw new ArgumentException("method");
            }
            result = new InsightlyResponse<T>((int)response.Result.StatusCode, responseData);
         }
         catch
         {
            result = new InsightlyResponse<T>(500, default(T));
         }
         return result;
      }

      public FlurlClient Authorise(string path)
      {
         var request = InsightlyUri + path;
         return request.WithBasicAuth(ApiKey, "");
      }
   }
}