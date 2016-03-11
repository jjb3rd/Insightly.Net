namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class Link : IInsightlyObject
   {
      [JsonProperty(PropertyName = "LINK_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int Id { get; set; }

      [JsonProperty(PropertyName = "CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int ContactId { get; set; }

      [JsonProperty(PropertyName = "OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OpportunityId { get; set; }

      [JsonProperty(PropertyName = "ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OrganisationId { get; set; }

      [JsonProperty(PropertyName = "PROJECT_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int ProjectId { get; set; }

      [JsonProperty(PropertyName = "SECOND_PROJECT_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int SecondProjectId { get; set; }

      [JsonProperty(PropertyName = "SECOND_OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int SecondOpportunityId { get; set; }

      [JsonProperty(PropertyName = "ROLE", NullValueHandling = NullValueHandling.Ignore)]
      public string Role { get; set; }

      [JsonProperty(PropertyName = "DETAILS", NullValueHandling = NullValueHandling.Ignore)]
      public string Details { get; set; }
   }
}