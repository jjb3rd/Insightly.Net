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
  public class Task
  {
    [JsonProperty(PropertyName = "TASK_ID")]
    public int Id { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty(PropertyName = "TITLE")]
    public string Title { get; set; }

    [JsonProperty(PropertyName = "CATEGORY_ID")]
    public int CategoryId { get; set; }

    [JsonConverter(typeof(InsightlyDateTimeConverter))]
    [JsonProperty(PropertyName = "DUE_DATE")]
    public DateTime? DueDate { get; set; }

    [JsonConverter(typeof(InsightlyDateTimeConverter))]
    [JsonProperty(PropertyName = "COMPLETED_DATE_UTC")]
    public DateTime? CompletedDateUtc { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty(PropertyName = "PUBLICLY_VISIBLE")]
    public bool PubliclyVisible { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty(PropertyName = "COMPLETED")]
    public bool Completed { get; set; }

    [JsonProperty(PropertyName = "PROJECT_ID")]
    public int ProjectId { get; set; }

    [JsonProperty(PropertyName = "DETAILS")]
    public string Details { get; set; }

    /// <summary>
    /// 'Completed', 'Deferred', 'In Progress', 'Not Started', 'Waiting'
    /// </summary>
    [JsonProperty(PropertyName = "STATUS")]
    public string Status { get; set; }

    [JsonProperty(PropertyName = "PRIORITY")]
    public int Priority { get; set; }

    [JsonProperty(PropertyName = "PERCENT_COMPLETE")]
    public int PercentComplete { get; set; }

    [JsonConverter(typeof(InsightlyDateTimeConverter))]
    [JsonProperty(PropertyName = "START_DATE")]
    public DateTime? StartDate { get; set; }

    [JsonProperty(PropertyName = "ASSIGNED_BY_USER_ID")]
    public int AssignedByUserId { get; set; }

    [JsonProperty(PropertyName = "PARENT_TASK_ID")]
    public int ParentTaskId { get; set; }

    [JsonProperty(PropertyName = "OWNER_VISIBLE")]
    public bool? OwnerVisible { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty(PropertyName = "RESPONSIBLE_USER_ID")]
    public int ResponsibleUserId { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty(PropertyName = "OWNER_USER_ID")]
    public int OwnerUserId { get; set; }

    [JsonConverter(typeof(InsightlyDateTimeConverter))]
    [JsonProperty(PropertyName = "DATE_CREATED_UTC")]
    public DateTime? DateCreatedUtc { get; set; }

    [JsonConverter(typeof(InsightlyDateTimeConverter))]
    [JsonProperty(PropertyName = "DATE_UPDATED_UTC")]
    public DateTime? DateUpdatedUtc { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), JsonProperty(PropertyName = "TASKLINKS")]
    public TaskLink[] TaskLinks { get; set; }
  }
}