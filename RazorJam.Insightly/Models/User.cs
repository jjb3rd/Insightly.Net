namespace RazorJam.Insightly.Models
{
   using System;
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class User : IInsightlyObject
   {
      [JsonProperty(PropertyName = "USER_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int UserId { get; set; }

      [JsonProperty(PropertyName = "CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int ContactId { get; set; }

      [JsonProperty(PropertyName = "FIRST_NAME", NullValueHandling = NullValueHandling.Ignore)]
      public string FirstName { get; set; }

      [JsonProperty(PropertyName = "LAST_NAME", NullValueHandling = NullValueHandling.Ignore)]
      public string LastName { get; set; }

      [JsonProperty(PropertyName = "TIMEZONE_ID", NullValueHandling = NullValueHandling.Ignore)]
      public string TimeZoneId { get; set; }

      [JsonProperty(PropertyName = "EMAIL_ADDRESS", NullValueHandling = NullValueHandling.Ignore)]
      public string EmailAddress { get; set; }

      [JsonProperty(PropertyName = "EMAIL_DROPBOX_IDENTIFIER", NullValueHandling = NullValueHandling.Ignore)]
      public string EmailDropBoxId { get; set; }

      [JsonProperty(PropertyName = "ADMINISTRATOR", NullValueHandling = NullValueHandling.Ignore)]
      public bool Administrator { get; set; }

      [JsonProperty(PropertyName = "ACCOUNT_OWNER", NullValueHandling = NullValueHandling.Ignore)]
      public bool AccountOwner { get; set; }

      [JsonProperty(PropertyName = "ACTIVE", NullValueHandling = NullValueHandling.Ignore)]
      public bool Active { get; set; }

      [JsonProperty(PropertyName = "DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
      public DateTime DateCreatedUtc { get; set; }

      [JsonProperty(PropertyName = "DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
      public DateTime DateUpdatedUtc { get; set; }

      [JsonProperty(PropertyName = "USER_CURRENCY", NullValueHandling = NullValueHandling.Ignore)]
      public string UserCurrency { get; set; }

      [JsonProperty(PropertyName = "CONTACT_DISPLAY", NullValueHandling = NullValueHandling.Ignore)]
      public string ContactDisplay { get; set; }

      [JsonProperty(PropertyName = "CONTACT_ORDER", NullValueHandling = NullValueHandling.Ignore)]
      public string ContactOrder { get; set; }

      [JsonProperty(PropertyName = "TASK_WEEK_START", NullValueHandling = NullValueHandling.Ignore)]
      public int TaskWeekStart { get; set; }

      [JsonProperty(PropertyName = "INSTANCE_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int InstanceId { get; set; }
   }
}