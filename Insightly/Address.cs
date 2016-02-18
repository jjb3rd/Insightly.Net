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
  public class Address
  {
    [JsonProperty(PropertyName = "ADDRESS_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int Id { get; set; }

    /// <summary>
    /// Required.  Acceptable values include 'Work', 'Postal' and 'Other'
    /// </summary>
    [JsonProperty(PropertyName = "ADDRESS_TYPE", NullValueHandling = NullValueHandling.Ignore)]
    public string AddressType { get; set; }

    [JsonProperty(PropertyName = "STREET", NullValueHandling = NullValueHandling.Ignore)]
    public string Street { get; set; }

    [JsonProperty(PropertyName = "CITY", NullValueHandling = NullValueHandling.Ignore)]
    public string City { get; set; }

    [JsonProperty(PropertyName = "STATE", NullValueHandling = NullValueHandling.Ignore)]
    public string State { get; set; }

    [JsonProperty(PropertyName = "POSTCODE", NullValueHandling = NullValueHandling.Ignore)]
    public string PostalCode { get; set; }

    [JsonProperty(PropertyName = "COUNTRY", NullValueHandling = NullValueHandling.Ignore)]
    public string Country { get; set; }
  }
}