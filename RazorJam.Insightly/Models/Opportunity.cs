namespace RazorJam.Insightly.Models
{
   using System.Collections.Generic;
   using Newtonsoft.Json;

   [JsonObject(MemberSerialization.OptIn)]
   public class Opportunity : IInsightlyObject
   {
      [JsonProperty(PropertyName = "OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int Id { get; set; }

      [JsonProperty(PropertyName = "OPPORTUNITY_NAME", NullValueHandling = NullValueHandling.Ignore)]
      public string Name { get; set; }

      [JsonProperty(PropertyName = "OPPORTUNITY_DETAILS", NullValueHandling = NullValueHandling.Ignore)]
      public string Details { get; set; }

      [JsonProperty(PropertyName = "PROBABILITY", NullValueHandling = NullValueHandling.Ignore)]
      public int Probability { get; set; }

      [JsonProperty(PropertyName = "BID_CURRENCY", NullValueHandling = NullValueHandling.Ignore)]
      public string BidCurrency { get; set; }

      [JsonProperty(PropertyName = "BID_AMOUNT", NullValueHandling = NullValueHandling.Ignore)]
      public int BidAmount { get; set; }

      [JsonProperty(PropertyName = "BID_TYPE", NullValueHandling = NullValueHandling.Ignore)]
      public string BidType { get; set; }

      [JsonProperty(PropertyName = "BID_DURATION", NullValueHandling = NullValueHandling.Ignore)]
      public int BidDuration { get; set; }

      [JsonProperty(PropertyName = "FORECAST_CLOSE_DATE", NullValueHandling = NullValueHandling.Ignore)]
      public string ForecastCloseDate { get; set; }

      [JsonProperty(PropertyName = "ACTUAL_CLOSE_DATE", NullValueHandling = NullValueHandling.Ignore)]
      public string ActualCloseDate { get; set; }

      [JsonProperty(PropertyName = "CATEGORY_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int CategoryId { get; set; }

      [JsonProperty(PropertyName = "PIPELINE_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int PipelineId { get; set; }

      [JsonProperty(PropertyName = "STAGE_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int StageId { get; set; }

      [JsonProperty(PropertyName = "OPPORTUNITY_STATE", NullValueHandling = NullValueHandling.Ignore)]
      public string State { get; set; }

      [JsonProperty(PropertyName = "IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
      public string ImageUrl { get; set; }

      [JsonProperty(PropertyName = "RESPONSIBLE_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int ResponsibleUserId { get; set; }

      [JsonProperty(PropertyName = "OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OwnerUserId { get; set; }

      [JsonProperty(PropertyName = "DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
      public string DateCreatedUtc { get; set; }

      [JsonProperty(PropertyName = "DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
      public string DateUpdatedUtc { get; set; }

      [JsonProperty(PropertyName = "VISIBLE_TO", NullValueHandling = NullValueHandling.Ignore)]
      public string VisibleTo { get; set; }

      [JsonProperty(PropertyName = "VISIBLE_TEAM_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int VisibleTeamId { get; set; }

      [JsonProperty(PropertyName = "VISIBLE_USER_IDS", NullValueHandling = NullValueHandling.Ignore)]
      public string VisibleUserIds { get; set; }

      [JsonProperty(PropertyName = "CUSTOMFIELDS", NullValueHandling = NullValueHandling.Ignore)]
      public IEnumerable<CustomField> Customfields { get; set; }

      [JsonProperty(PropertyName = "TAGS", NullValueHandling = NullValueHandling.Ignore)]
      public IEnumerable<Tag> Tags { get; set; }

      [JsonProperty(PropertyName = "LINKS", NullValueHandling = NullValueHandling.Ignore)]
      public IEnumerable<Link> Links { get; set; }

      [JsonProperty(PropertyName = "EMAILLINKS", NullValueHandling = NullValueHandling.Ignore)]
      public IEnumerable<EmailLink> Emaillinks { get; set; }

      [JsonProperty(PropertyName = "FILE_ATTACHMENTS", NullValueHandling = NullValueHandling.Ignore)]
      public IEnumerable<FileAttachment> FileAttachments { get; set; }
   }
}