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
  public class ContactInfo
  {
    [JsonProperty(PropertyName = "CONTACT_INFO_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int Id { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty(PropertyName = "TYPE", NullValueHandling = NullValueHandling.Ignore)]
    public string ContactType { get; set; }

    [JsonProperty(PropertyName = "SUBTYPE", NullValueHandling = NullValueHandling.Ignore)]
    public string ContactSubtype { get; set; }

    [JsonProperty(PropertyName = "LABEL", NullValueHandling = NullValueHandling.Ignore)]
    public string Label { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty(PropertyName = "DETAIL", NullValueHandling = NullValueHandling.Ignore)]
    public string Detail { get; set; }
  }
}