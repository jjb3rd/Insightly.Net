namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class Date : IInsightlyObject
   {
      [JsonProperty(PropertyName = "DATE_ID")]
      public int Id { get; set; }

      [JsonProperty(PropertyName = "OCCASION_NAME")]
      public string OccasionName { get; set; }

      [JsonProperty(PropertyName = "OCCASION_DATE")]
      public string OccasionDate { get; set; }

      [JsonProperty(PropertyName = "REPEAT_YEARLY")]
      public bool RepeatYearly { get; set; }

      [JsonProperty(PropertyName = "CREATE_TASK_YEARLY")]
      public bool CreateTaskYearly { get; set; }
   }
}