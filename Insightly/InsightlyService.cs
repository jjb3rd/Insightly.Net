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
namespace Insightly
{
  using System;
  using System.Collections.Generic;
  using Flurl.Http;
  using System.Threading.Tasks;
  using System.Runtime.Caching;

  public static class InsightlyService
  {
    private static Uri _apiUri = new Uri("https://api.insight.ly/v2.1");
    public static string ApiKey { private get; set; }

    private static ObjectCache cache = MemoryCache.Default;
    private static CacheItemPolicy StandardPolicy() { return new CacheItemPolicy() { AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(10) }; }

    #region Shared
    private static FlurlClient Authorise( string path )
    {
      string request = _apiUri + path;
      return request.WithBasicAuth(ApiKey, "");
    }

    private static async Task<T> DoRequest<T>( string url, string method, object body )
    {
      FlurlClient request = Authorise(url);
      T response = default(T);
      try
      {
        switch( method.ToLower() )
        {
          case "post":
            if( body == null )
              throw new ArgumentNullException("body");
            response = await request.PostJsonAsync(body).ReceiveJson<T>().ConfigureAwait(false);
            break;
          case "get":
            response = await request.GetJsonAsync<T>().ConfigureAwait(false);
            break;
        }
      }
      catch { }
      return response;
    }
    #endregion

    #region Contacts
    public static Contact CreateContactAsync( Contact contact )
    {
      if( contact == null )
        throw new ArgumentNullException("contact");
      cache.Remove("Contacts");
      return DoRequest<Contact>("/Contacts", "POST", contact).Result;
    }

    public static IEnumerable<Contact> GetContactsAsync( bool Brief = true )
    {
      if( cache[ "Contacts" ] == null )
      {
        string url = "/Contacts";
        if( Brief )
          url += "?Brief=True";
        cache.Set("Contacts", DoRequest<IEnumerable<Contact>>(url, "GET", null).Result, StandardPolicy());
      }
      return cache[ "Contacts" ] as IEnumerable<Contact>;
    }
    #endregion

    #region Organizations
    public static IEnumerable<Organization> GetOrganisationsAsync( bool Brief = true )
    {
      if( cache[ "Organisations" ] == null )
      {
        string url = "/Organisations";
        if( Brief )
          url += "?Brief=True";
        cache.Set("Organisations", DoRequest<IEnumerable<Organization>>(url, "GET", null).Result, StandardPolicy());
      }
      return cache[ "Organisations" ] as IEnumerable<Organization>;
    }
    #endregion
  }
}
