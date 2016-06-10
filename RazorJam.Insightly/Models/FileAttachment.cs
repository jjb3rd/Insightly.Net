namespace RazorJam.Insightly.Models
{
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class FileAttachment : IInsightlyObject
   {
      [JsonProperty(PropertyName = "FILE_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int FileId { get; set; }

      [JsonProperty(PropertyName = "FILE_NAME", NullValueHandling = NullValueHandling.Ignore)]
      public string FileName { get; set; }

      [JsonProperty(PropertyName = "CONTENT_TYPE", NullValueHandling = NullValueHandling.Ignore)]
      public string ContentType { get; set; }

      [JsonProperty(PropertyName = "FILE_SIZE", NullValueHandling = NullValueHandling.Ignore)]
      public int FileSize { get; set; }

      [JsonProperty(PropertyName = "FILE_CATEGORY_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int FileCategoryId { get; set; }

      [JsonProperty(PropertyName = "OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OwnerUserId { get; set; }

      [JsonProperty(PropertyName = "DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
      public string DateCreatedUtc { get; set; }

      [JsonProperty(PropertyName = "DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
      public string DateUpdatedUtc { get; set; }

      [JsonProperty(PropertyName = "URL", NullValueHandling = NullValueHandling.Ignore)]
      public string Url { get; set; }
   }
}