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

  [JsonObject(MemberSerialization.OptIn)]
  public class Link
  {
    [JsonProperty(PropertyName = "LINK_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int Id { get; set; }

    [JsonProperty(PropertyName = "CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int ContactId { get; set; }

    [JsonProperty(PropertyName = "OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int OpportunityId { get; set; }

    [JsonProperty(PropertyName = "ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int OrganizationId { get; set; }

    [JsonProperty(PropertyName = "PROJECT_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int ProjectId { get; set; }

    [JsonProperty(PropertyName = "SECOND_PROJECT_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int SecondProjectId { get; set; }

    [JsonProperty(PropertyName = "SECOND_OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int SecondOpportunityId { get; set; }

    [JsonProperty(PropertyName = "ROLE", NullValueHandling = NullValueHandling.Ignore)]
    public string Role { get; set; }

    [JsonProperty(PropertyName = "DETAILS", NullValueHandling = NullValueHandling.Ignore)]
    public string Details { get; set; }
  }
}