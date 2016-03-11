namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class ContactInfo : IInsightlyObject
   {
      [JsonProperty(PropertyName = "CONTACT_INFO_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int Id { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [JsonProperty(PropertyName = "TYPE", NullValueHandling = NullValueHandling.Ignore)]
      public string ContactType { get; set; }

      [JsonProperty(PropertyName = "SUBTYPE", NullValueHandling = NullValueHandling.Ignore)]
      public string ContactSubtype { get; set; }

      [JsonProperty(PropertyName = "LABEL", NullValueHandling = NullValueHandling.Ignore)]
      public string Label { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [JsonProperty(PropertyName = "DETAIL", NullValueHandling = NullValueHandling.Ignore)]
      public string Detail { get; set; }
   }
}