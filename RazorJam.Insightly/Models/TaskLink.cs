namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class TaskLink : IInsightlyObject
   {
      [JsonProperty(PropertyName = "TASK_LINK_ID")]
      public int TaskLinkId { get; set; }

      [JsonProperty(PropertyName = "TASK_ID")]
      public int TaskId { get; set; }

      [JsonProperty(PropertyName = "CONTACT_ID")]
      public int ContactId { get; set; }

      [JsonProperty(PropertyName = "ORGANISATION_ID")]
      public int OrganizationId { get; set; }

      [JsonProperty(PropertyName = "OPPORTUNITY_ID")]
      public int OpportunityId { get; set; }

      [JsonProperty(PropertyName = "PROJECT_ID")]
      public int ProjectId { get; set; }
   }
}