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
  using Newtonsoft.Json;
  using System;

  [JsonObject(MemberSerialization.OptIn)]
  public class User
  {
    [JsonProperty(PropertyName = "USER_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int UserId { get; set; }

    [JsonProperty(PropertyName = "CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int ContactId { get; set; }

    [JsonProperty(PropertyName = "FIRST_NAME", NullValueHandling = NullValueHandling.Ignore)]
    public string FirstName { get; set; }

    [JsonProperty(PropertyName = "LAST_NAME", NullValueHandling = NullValueHandling.Ignore)]
    public string LastName { get; set; }

    [JsonProperty(PropertyName = "TIMEZONE_ID", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeZoneId { get; set; }

    [JsonProperty(PropertyName = "EMAIL_ADDRESS", NullValueHandling = NullValueHandling.Ignore)]
    public string EmailAddress { get; set; }

    [JsonProperty(PropertyName = "EMAIL_DROPBOX_IDENTIFIER", NullValueHandling = NullValueHandling.Ignore)]
    public string EmailDropBoxId { get; set; }

    [JsonProperty(PropertyName = "ADMINISTRATOR", NullValueHandling = NullValueHandling.Ignore)]
    public bool Administrator { get; set; }

    [JsonProperty(PropertyName = "ACCOUNT_OWNER", NullValueHandling = NullValueHandling.Ignore)]
    public bool AccountOwner { get; set; }

    [JsonProperty(PropertyName = "ACTIVE", NullValueHandling = NullValueHandling.Ignore)]
    public bool Active { get; set; }

    [JsonProperty(PropertyName = "DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime DateCreatedUtc { get; set; }

    [JsonProperty(PropertyName = "DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime DateUpdatedUtc { get; set; }

    [JsonProperty(PropertyName = "USER_CURRENCY", NullValueHandling = NullValueHandling.Ignore)]
    public string UserCurrency { get; set; }

    [JsonProperty(PropertyName = "CONTACT_DISPLAY", NullValueHandling = NullValueHandling.Ignore)]
    public string ContactDisplay { get; set; }

    [JsonProperty(PropertyName = "CONTACT_ORDER", NullValueHandling = NullValueHandling.Ignore)]
    public string ContactOrder { get; set; }

    [JsonProperty(PropertyName = "TASK_WEEK_START", NullValueHandling = NullValueHandling.Ignore)]
    public int TaskWeekStart { get; set; }

    [JsonProperty(PropertyName = "INSTANCE_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int InstanceId { get; set; }
  }
}