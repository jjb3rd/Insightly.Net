namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class Country : IInsightlyObject
   {
      [JsonProperty(PropertyName = "COUNTRY_NAME", NullValueHandling = NullValueHandling.Ignore)]
      public string Name { get; set; }
   }
}