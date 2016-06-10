namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;
   using System.Collections.Generic;

   [JsonObject(MemberSerialization.OptIn)]
   public class CustomField : IInsightlyObject
   {
      [JsonProperty(PropertyName = "CUSTOM_FIELD_ID", NullValueHandling = NullValueHandling.Ignore)]
      public string Id { get; set; }

      [JsonProperty(PropertyName = "FIELD_VALUE", NullValueHandling = NullValueHandling.Ignore)]
      public string Value { get; set; }

      [JsonProperty(PropertyName = "ORDER_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OrderId { get; set; }

      [JsonProperty(PropertyName = "FIELD_FOR", NullValueHandling = NullValueHandling.Ignore)]
      public string FieldFor { get; set; }

      [JsonProperty(PropertyName = "FIELD_NAME", NullValueHandling = NullValueHandling.Ignore)]
      public string FieldName { get; set; }

      [JsonProperty(PropertyName = "FIELD_TYPE", NullValueHandling = NullValueHandling.Ignore)]
      public string FieldType { get; set; }

      [JsonProperty(PropertyName = "FIELD_HELP_TEXT", NullValueHandling = NullValueHandling.Ignore)]
      public string FieldHelpText { get; set; }

      [JsonProperty(PropertyName = "DEFAULT_VALUE", NullValueHandling = NullValueHandling.Ignore)]
      public object DefaultValue { get; set; }

      [JsonProperty(PropertyName = "GROUP_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int GroupId { get; set; }
          
      [JsonProperty(PropertyName = "CUSTOM_FIELD_OPTIONS", NullValueHandling = NullValueHandling.Ignore)]
      public IEnumerable<CustomFieldOption> CustomFieldOptions { get; set; }
   }
}