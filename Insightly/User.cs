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
    [JsonProperty(PropertyName = "USER_ID")]
    public int UserId { get; set; }

    [JsonProperty(PropertyName = "CONTACT_ID")]
    public int ContactId { get; set; }

    [JsonProperty(PropertyName = "FIRST_NAME")]
    public string FirstName { get; set; }

    [JsonProperty(PropertyName = "LAST_NAME")]
    public string LastName { get; set; }

    [JsonProperty(PropertyName = "TIMEZONE_ID")]
    public string TimeZoneId { get; set; }

    [JsonProperty(PropertyName = "EMAIL_ADDRESS")]
    public string EmailAddress { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "DropBox"), JsonProperty(PropertyName = "EMAIL_DROPBOX_IDENTIFIER")]
    public string EmailDropBoxId { get; set; }

    [JsonProperty(PropertyName = "ADMINISTRATOR")]
    public bool Administrator { get; set; }

    [JsonProperty(PropertyName = "ACCOUNT_OWNER")]
    public bool AccountOwner { get; set; }

    [JsonProperty(PropertyName = "ACTIVE")]
    public bool Active { get; set; }

    [JsonProperty(PropertyName = "DATE_CREATED_UTC")]
    public DateTime DateCreatedUtc { get; set; }

    [JsonProperty(PropertyName = "DATE_UPDATED_UTC")]
    public DateTime DateUpdatedUtc { get; set; }

    [JsonProperty(PropertyName = "USER_CURRENCY")]
    public string UserCurrency { get; set; }

    [JsonProperty(PropertyName = "CONTACT_DISPLAY")]
    public string ContactDisplay { get; set; }

    [JsonProperty(PropertyName = "CONTACT_ORDER")]
    public string ContactOrder { get; set; }

    [JsonProperty(PropertyName = "TASK_WEEK_START")]
    public int TaskWeekStart { get; set; }

    [JsonProperty(PropertyName = "INSTANCE_ID")]
    public int InstanceId { get; set; }
  }
}