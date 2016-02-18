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
  public class Organisation
  {
    [JsonProperty(PropertyName = "ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int Id { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty(PropertyName = "ORGANISATION_NAME", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty(PropertyName = "BACKGROUND", NullValueHandling = NullValueHandling.Ignore)]
    public string Background { get; set; }

    [JsonProperty(PropertyName = "IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
    public string ImageUrl { get; set; }

    [JsonProperty(PropertyName = "OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int OwnerUserId { get; set; }

    [JsonConverter(typeof(InsightlyDateTimeConverter))]
    [JsonProperty(PropertyName = "DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime? DateCreatedUtc { get; set; }

    [JsonConverter(typeof(InsightlyDateTimeConverter))]
    [JsonProperty(PropertyName = "DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime? DateUpdatedUtc { get; set; }

    [JsonProperty(PropertyName = "VISIBLE_TO", NullValueHandling = NullValueHandling.Ignore)]
    public string VisibleTo { get; set; }

    [JsonProperty(PropertyName = "VISIBLE_TEAM_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int VisibleTeamId { get; set; }

    [JsonProperty(PropertyName = "VISIBLE_USER_IDS", NullValueHandling = NullValueHandling.Ignore)]
    public string VisibleUserIds { get; set; }

    [JsonProperty(PropertyName = "CUSTOMFIELDS", NullValueHandling = NullValueHandling.Ignore)]
    public CustomField[] CustomFields { get; set; }

    [JsonProperty(PropertyName = "ADDRESSES", NullValueHandling = NullValueHandling.Ignore)]
    public Address[] Addresses { get; set; }

    [JsonProperty(PropertyName = "CONTACTINFOS", NullValueHandling = NullValueHandling.Ignore)]
    public ContactInfo[] ContactInfos { get; set; }

    [JsonProperty(PropertyName = "DATES", NullValueHandling = NullValueHandling.Ignore)]
    public OrganizationDate[] Dates { get; set; }

    [JsonProperty(PropertyName = "TAGS", NullValueHandling = NullValueHandling.Ignore)]
    public Tag[] Tags { get; set; }

    [JsonProperty(PropertyName = "LINKS", NullValueHandling = NullValueHandling.Ignore)]
    public Link[] Links { get; set; }

    [JsonProperty(PropertyName = "ORGANISATIONLINKS", NullValueHandling = NullValueHandling.Ignore)]
    public OrganizationLink[] OrganizationLinks { get; set; }

    [JsonProperty(PropertyName = "EMAILLINKS", NullValueHandling = NullValueHandling.Ignore)]
    public EmailLink[] EmailLinks { get; set; }
  }
}