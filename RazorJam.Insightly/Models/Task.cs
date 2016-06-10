namespace RazorJam.Insightly.Models
{
   using System;
   using Newtonsoft.Json;
   using RazorJam.Insightly.Implementations;

   [JsonObject(MemberSerialization.OptIn)]
   public class Task : IInsightlyObject
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