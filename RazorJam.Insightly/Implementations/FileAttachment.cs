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

namespace RazorJam.Insightly.Implementations
{
  [JsonObject(MemberSerialization.OptIn)]
  public class FileAttachment: IInsightlyObject
   {
    [JsonProperty(PropertyName = "FILE_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int FileId { get; set; }

    [JsonProperty(PropertyName = "FILE_NAME", NullValueHandling = NullValueHandling.Ignore)]
    public string FileName { get; set; }

    [JsonProperty(PropertyName = "CONTENT_TYPE", NullValueHandling = NullValueHandling.Ignore)]
    public string ContentType { get; set; }

    [JsonProperty(PropertyName = "FILE_SIZE", NullValueHandling = NullValueHandling.Ignore)]
    public int FileSize { get; set; }

    [JsonProperty(PropertyName = "FILE_CATEGORY_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int FileCategoryId { get; set; }

    [JsonProperty(PropertyName = "OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
    public int OwnerUserId { get; set; }

    [JsonProperty(PropertyName = "DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
    public string DateCreatedUtc { get; set; }

    [JsonProperty(PropertyName = "DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
    public string DateUpdatedUtc { get; set; }

    [JsonProperty(PropertyName = "URL", NullValueHandling = NullValueHandling.Ignore)]
    public string Url { get; set; }
  }
}