namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class OrganizationLink : IInsightlyObject
   {
      [JsonProperty(PropertyName = "ORG_LINK_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int Id { get; set; }

      [JsonProperty(PropertyName = "FIRST_ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int ContactId { get; set; }

      [JsonProperty(PropertyName = "SECOND_ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OpportunityId { get; set; }

      [JsonProperty(PropertyName = "RELATIONSHIP_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OrganizationId { get; set; }

      [JsonProperty(PropertyName = "DETAILS", NullValueHandling = NullValueHandling.Ignore)]
      public string Details { get; set; }
   }
}