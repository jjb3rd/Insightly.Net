namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class Address: IInsightlyObject
   {
      [JsonProperty(PropertyName = "ADDRESS_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int Id { get; set; }

      /// <summary>
      /// Required.  Acceptable values include 'Work', 'Postal' and 'Other'
      /// </summary>
      [JsonProperty(PropertyName = "ADDRESS_TYPE", NullValueHandling = NullValueHandling.Ignore)]
      public string AddressType { get; set; }

      [JsonProperty(PropertyName = "STREET", NullValueHandling = NullValueHandling.Ignore)]
      public string Street { get; set; }

      [JsonProperty(PropertyName = "CITY", NullValueHandling = NullValueHandling.Ignore)]
      public string City { get; set; }

      [JsonProperty(PropertyName = "STATE", NullValueHandling = NullValueHandling.Ignore)]
      public string State { get; set; }

      [JsonProperty(PropertyName = "POSTCODE", NullValueHandling = NullValueHandling.Ignore)]
      public string PostalCode { get; set; }

      [JsonProperty(PropertyName = "COUNTRY", NullValueHandling = NullValueHandling.Ignore)]
      public string Country { get; set; }
   }
}