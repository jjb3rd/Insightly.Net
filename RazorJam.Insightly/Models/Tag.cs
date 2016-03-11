namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class Tag : IInsightlyObject
   {
      [JsonProperty(PropertyName = "TAG_NAME", NullValueHandling = NullValueHandling.Ignore)]
      public string OccasionName { get; set; }
   }
}