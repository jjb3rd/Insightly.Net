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
using Newtonsoft.Json;

namespace RazorJam.Insightly.Implementations
{
  [JsonObject(MemberSerialization.OptIn)]
  public class OrganizationDate: IInsightlyObject
   {
    [JsonProperty(PropertyName = "DATE_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int Id { get; set; }

    [JsonProperty(PropertyName = "OCCASION_NAME", NullValueHandling = NullValueHandling.Ignore)]
    public string OccasionName { get; set; }

    [JsonConverter(typeof(InsightlyDateTimeConverter))]
    [JsonProperty(PropertyName = "OCCASION_DATE", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime? OccasionDate { get; set; }

    [JsonProperty(PropertyName = "REPEAT_YEARLY", NullValueHandling = NullValueHandling.Ignore)]
    public bool? RepeatYearly { get; set; }

    [JsonProperty(PropertyName = "CREATE_TASK_YEARLY", NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateTaskYearly { get; set; }
  }
}