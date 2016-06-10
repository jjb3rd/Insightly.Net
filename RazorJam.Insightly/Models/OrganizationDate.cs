namespace RazorJam.Insightly.Models
{
   using System;
   using Newtonsoft.Json;
   using RazorJam.Insightly.Implementations;

   [JsonObject(MemberSerialization.OptIn)]
   public class OrganizationDate : IInsightlyObject
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