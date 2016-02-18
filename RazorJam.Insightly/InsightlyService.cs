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

using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Threading.Tasks;
using Flurl.Http;

namespace RazorJam.Insightly
{
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
          case "put":
            if( body == null )
              throw new ArgumentNullException("body");
            response = await request.PutJsonAsync(body).ReceiveJson<T>().ConfigureAwait(false);
            break;
        }
      }
      catch { }
      return response;
    }

    private static object GetRequestCached<T>( string url )
    {
      if( cache[ url ] == null )
      {
        cache.Set(url, DoRequest<T>(url, "GET", null).Result, StandardPolicy());
      }
      return cache[ url ];
    }
    #endregion

    #region Contacts
    public static Contact CreateContactAsync( Contact contact )
    {
      if( contact == null )
        throw new ArgumentNullException("contact");
      cache.Remove("/Contacts");
      return DoRequest<Contact>("/Contacts", "POST", contact).Result;
    }

    public static IEnumerable<Contact> GetContactsAsync()
    {
      return GetRequestCached<IEnumerable<Contact>>("/Contacts") as IEnumerable<Contact>;
    }

    public static Contact GetContactAsync( int id )
    {
      return GetRequestCached<Contact>("/Contacts/" + id.ToString()) as Contact;
    }

    public static Contact UpdateContactAsync( Contact contact )
    {
      if( contact == null )
        throw new ArgumentNullException("contact");
      Contact response = DoRequest<Contact>("/Contacts", "PUT", contact).Result;
      if (response != null)
      {
        cache.Set("/Contacts/" + response.Id, response, StandardPolicy());
        cache.Remove("/Contacts");
      }
      return response;
    }
    #endregion

    #region Organisations
    public static IEnumerable<Organisation> GetOrganisationsAsync()
    {
      return GetRequestCached<IEnumerable<Organisation>>("/Organisations") as IEnumerable<Organisation>;
    }

    public static Organisation GetOrganisationAsync( int id )
    {
      return GetRequestCached<Organisation>("/Organisations/" + id.ToString()) as Organisation;
    }
    #endregion

    #region Opportunities
    public static IEnumerable<Opportunity> GetOpportunitiesAsync()
    {
      return GetRequestCached<IEnumerable<Opportunity>>("/Opportunities") as IEnumerable<Opportunity>;
    }

    public static Opportunity GetOpportunityAsync( int id )
    {
      return GetRequestCached<Opportunity>("/Opportunities/" + id.ToString()) as Opportunity;
    }
    #endregion

    #region Users
    public static IEnumerable<User> GetUsersAsync()
    {
      return GetRequestCached<IEnumerable<User>>("/Users") as IEnumerable<User>;
    }

    public static User GetUserAsync( int id )
    {
      return GetRequestCached<User>("/Users/" + id.ToString()) as User;
    }
    #endregion
  }
}