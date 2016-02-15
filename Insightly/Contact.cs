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
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Insightly
{
  [JsonObject(MemberSerialization.OptIn)]
  public class Contact
  {
    public Contact() { }

    public Contact( string fullName )
    {
      //string[] salutations = new string[] { "MR", "MS", "MRS", "MISS", "DR" };
      if( !string.IsNullOrWhiteSpace(fullName) )
      {
        int lastSpace = fullName.LastIndexOf(' ');
        if( lastSpace > 0 )
        {
          this.FirstName = fullName.Substring(0, fullName.Length - lastSpace);
          this.LastName = fullName.Substring(lastSpace);
        }
        else
        {
          this.FirstName = fullName;
        }
      }
    }

    [JsonProperty(PropertyName = "CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty(PropertyName = "SALUTATION", NullValueHandling = NullValueHandling.Ignore)]
    public string Salutation { get; set; }

    [JsonProperty(PropertyName = "FIRST_NAME", NullValueHandling = NullValueHandling.Ignore)]
    public string FirstName { get; set; }

    [JsonProperty(PropertyName = "LAST_NAME", NullValueHandling = NullValueHandling.Ignore)]
    public string LastName { get; set; }

    [JsonProperty(PropertyName = "BACKGROUND", NullValueHandling = NullValueHandling.Ignore)]
    public string Background { get; set; }

    [JsonProperty(PropertyName = "IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
    public string ImageUrl { get; set; }

    [JsonProperty(PropertyName = "DEFAULT_LINKED_ORGANISATION", NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultLinkedOrganisation { get; set; }

    [JsonProperty(PropertyName = "OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int? OwnerUserId { get; set; }

    [JsonProperty(PropertyName = "DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
    public string DateCreated { get; set; }

    [JsonProperty(PropertyName = "DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
    public string DateUpdated { get; set; }

    [JsonProperty(PropertyName = "VISIBLE_TO", NullValueHandling = NullValueHandling.Ignore)]
    public string VisibleTo { get; set; }

    [JsonProperty(PropertyName = "VISIBLE_TEAM_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int? VisibleTeamId { get; set; }

    [JsonProperty(PropertyName = "VISIBLE_USER_IDS", NullValueHandling = NullValueHandling.Ignore)]
    public string VisibleUserIds { get; set; }

    [JsonProperty(PropertyName = "CUSTOMFIELDS", NullValueHandling = NullValueHandling.Ignore)]
    public IEnumerable<CustomField> CustomFields { get; set; }

    [JsonProperty(PropertyName = "ADDRESSES", NullValueHandling = NullValueHandling.Ignore)]
    public IEnumerable<Address> Addresses { get; set; }

    [JsonProperty(PropertyName = "CONTACTINFOS", NullValueHandling = NullValueHandling.Ignore)]
    public IEnumerable<ContactInfo> ContactInfos { get; set; }

    [JsonProperty(PropertyName = "DATES", NullValueHandling = NullValueHandling.Ignore)]
    public IEnumerable<Date> Dates { get; set; }

    [JsonProperty(PropertyName = "TAGS", NullValueHandling = NullValueHandling.Ignore)]
    public IEnumerable<Tag> Tags { get; set; }

    [JsonProperty(PropertyName = "LINKS", NullValueHandling = NullValueHandling.Ignore)]
    public IEnumerable<Link> Links { get; set; }

    [JsonProperty(PropertyName = "CONTACTLINKS", NullValueHandling = NullValueHandling.Ignore)]
    public IEnumerable<ContactLink> ContactLinks { get; set; }

    [JsonProperty(PropertyName = "EMAILLINKS", NullValueHandling = NullValueHandling.Ignore)]
    public IEnumerable<EmailLink> EmailLinks { get; set; }
  }
}