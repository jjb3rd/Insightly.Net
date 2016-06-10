namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class EmailLink : IInsightlyObject
   {
      [JsonProperty(PropertyName = "EMAIL_LINK_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int Id { get; set; }

      [JsonProperty(PropertyName = "EMAIL_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int EmailId { get; set; }

      [JsonProperty(PropertyName = "CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int ContactId { get; set; }

      [JsonProperty(PropertyName = "ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OrganizationId { get; set; }

      [JsonProperty(PropertyName = "OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OpportunityId { get; set; }

      [JsonProperty(PropertyName = "PROJECT_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int ProjectId { get; set; }

   }
}