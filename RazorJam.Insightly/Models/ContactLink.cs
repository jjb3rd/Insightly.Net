namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class ContactLink : IInsightlyObject
   {
      [JsonProperty(PropertyName = "CONTACT_LINK_ID")]
      public int Id { get; set; }

      [JsonProperty(PropertyName = "FIRST_CONTACT_ID")]
      public int FirstContactId { get; set; }

      [JsonProperty(PropertyName = "SECOND_CONTACT_ID")]
      public int SecondContactId { get; set; }

      [JsonProperty(PropertyName = "RELATIONSHIP_ID")]
      public int RelationshipId { get; set; }

      [JsonProperty(PropertyName = "DETAILS")]
      public string Details { get; set; }
   }
}