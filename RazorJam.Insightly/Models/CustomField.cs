namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class CustomField : IInsightlyObject
   {
      [JsonProperty(PropertyName = "CUSTOM_FIELD_ID", NullValueHandling = NullValueHandling.Ignore)]
      public string Id { get; set; }

      [JsonProperty(PropertyName = "FIELD_VALUE", NullValueHandling = NullValueHandling.Ignore)]
      public string FieldValue { get; set; }
   }
}