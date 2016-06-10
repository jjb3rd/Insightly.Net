namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;
   using System.Collections.Generic;

   [JsonObject(MemberSerialization.OptIn)]
   public class CustomFieldOption : IInsightlyObject
   {
      [JsonProperty(PropertyName = "OPTION_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int Id { get; set; }

      [JsonProperty(PropertyName = "OPTION_VALUE", NullValueHandling = NullValueHandling.Ignore)]
      public string Value { get; set; }

      [JsonProperty(PropertyName = "OPTION_DEFAULT", NullValueHandling = NullValueHandling.Ignore)]
      public bool Default { get; set; }
   }
}