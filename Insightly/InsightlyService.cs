/*
 * Copyright 2014 Beckersoft, Inc.
 *
 * Author(s):
 *  John Becker (john@beckersoft.com)
 *  
 *  Some web code is derived from work authored by:
 * 	Gonzalo Paniagua Javier (gonzalo@xamarin.com)
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Insightly
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Insightly")]
    public class InsightlyService
    {
        private static Uri _apiUri = new Uri("https://api.insight.ly/v2.1");
        private static readonly Encoding _encoding = Encoding.UTF8;
        private static JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "api")]
        public InsightlyService(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        private string UserAgent = "Insightly.NET/0.1";

        public int TimeoutSeconds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Api")]
        public string ApiKey { get; set; }
        
        #region Shared

        protected virtual WebRequest SetupRequest(string method, Uri uri)
        {
            WebRequest webRequest = (WebRequest)WebRequest.Create(uri);
            webRequest.Method = method;
            HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
            if (httpWebRequest != null)
            {
                httpWebRequest.UserAgent = UserAgent;
            }
            webRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(this.ApiKey + ":" )); //no password
            //req.Headers["Accept-Encoding"] = "gip";
            //req.Timeout = TimeoutSeconds * 1000;
            if (method == "POST")
            {
                //req.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentType = "application/json";
            }
            return webRequest;
        }

        static string GetResponseAsString(WebResponse response)
        {
            using (StreamReader sr = new StreamReader(response.GetResponseStream(), _encoding))
            {
                return sr.ReadToEnd();
            }
        }

        protected virtual T DoRequest<T>(Uri uri)
        {
            return DoRequest<T>(uri, "GET", null);
        }

        protected virtual T DoRequest<T>(Uri uri, string method, string body)
        {
            var json = DoRequest(uri, method, body);
            return JsonConvert.DeserializeObject<T>(json);
        }

        protected virtual string DoRequest(Uri uri)
        {
            return DoRequest(uri, "GET", null);
        }

        protected virtual string DoRequest(Uri uri, string method, string body)
        {
            string result = null;
            WebRequest req = SetupRequest(method, uri);
            if (body != null)
            {
                byte[] bytes = _encoding.GetBytes(body.ToString());
                req.ContentLength = bytes.Length;
                using (Stream st = req.GetRequestStream())
                {
                    st.Write(bytes, 0, bytes.Length);
                }
            }

            try
            {
                using (WebResponse resp = (WebResponse)req.GetResponse())
                {
                    result = GetResponseAsString(resp);
                }
            }
            catch (WebException wexc)
            {
                if (wexc.Response != null)
                {
                    /*
                    string json_error = GetResponseAsString(wexc.Response);
                    HttpStatusCode status_code = HttpStatusCode.BadRequest;
                    HttpWebResponse resp = wexc.Response as HttpWebResponse;
                    if (resp != null)
                        status_code = resp.StatusCode;

                    //if ((int)status_code <= 500)
                    //    throw StripeException.GetFromJSON(status_code, json_error);
                    */
                }
                throw;
            }
            return result;
        }

        protected virtual Uri UriForPath(string path)
        {
            UriBuilder uriBuilder = new UriBuilder(_apiUri);
            uriBuilder.Path += path;
            return uriBuilder.Uri;
        }
        #endregion

        #region Contacts
        public Contact CreateContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException("contact");
            }
            string json = JsonConvert.SerializeObject(contact, _jsonSerializerSettings);
            return DoRequest<Contact>(UriForPath("/Contacts"), "POST", json);

        }
        #endregion

        #region Tasks
        public Task CreateTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("task");
            }


            return DoRequest<Task>(UriForPath("/Tasks"),
                        "POST",
                        JsonConvert.SerializeObject(task, _jsonSerializerSettings)
                        );
        }

        public Task GetTask(int id)
        {
            if(id < 1)
            {
                throw new ArgumentOutOfRangeException("id", "Task Id must be greater than zero!");
            }
            return DoRequest<Task>(UriForPath("/Tasks/" + id.ToString(CultureInfo.InvariantCulture)));
        }
        #endregion

        #region Organizations
        public Organization CreateOrganization(Organization organization)
        {
            if (organization == null)
            {
                throw new ArgumentNullException("organization");
            }
            return DoRequest<Organization>(UriForPath("/Organisations"), "POST", JsonConvert.SerializeObject(organization, _jsonSerializerSettings));
        }

        #endregion

        #region Users
        public IEnumerable<User> Users
        {
            get
            {
                return DoRequest<IEnumerable<User>>(UriForPath("/Users"));
            }
        }
        #endregion

        public Contact GetContact(int id)
        {
            if(id < 1)
            {
                throw new ArgumentOutOfRangeException("id", "Contact Id must be greater than zero!");
            }
            return DoRequest<Contact>(UriForPath("/Contacts/" + id.ToString(CultureInfo.InvariantCulture)));
        }
    }
}
