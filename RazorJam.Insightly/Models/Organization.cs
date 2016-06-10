namespace RazorJam.Insightly.Models
{
   using System;
   using Newtonsoft.Json;
   using RazorJam.Insightly.Implementations;

   [JsonObject(MemberSerialization.OptIn)]
   public class Organisation : IInsightlyObject
   {
      [JsonProperty(PropertyName = "ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int Id { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [JsonProperty(PropertyName = "ORGANISATION_NAME", NullValueHandling = NullValueHandling.Ignore)]
      public string Name { get; set; }

      [JsonProperty(PropertyName = "BACKGROUND", NullValueHandling = NullValueHandling.Ignore)]
      public string Background { get; set; }

      [JsonProperty(PropertyName = "IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
      public string ImageUrl { get; set; }

      [JsonProperty(PropertyName = "OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int OwnerUserId { get; set; }

      [JsonConverter(typeof(InsightlyDateTimeConverter))]
      [JsonProperty(PropertyName = "DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
      public DateTime? DateCreatedUtc { get; set; }

      [JsonConverter(typeof(InsightlyDateTimeConverter))]
      [JsonProperty(PropertyName = "DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
      public DateTime? DateUpdatedUtc { get; set; }

      [JsonProperty(PropertyName = "VISIBLE_TO", NullValueHandling = NullValueHandling.Ignore)]
      public string VisibleTo { get; set; }

      [JsonProperty(PropertyName = "VISIBLE_TEAM_ID", NullValueHandling = NullValueHandling.Ignore)]
      public int VisibleTeamId { get; set; }

      [JsonProperty(PropertyName = "VISIBLE_USER_IDS", NullValueHandling = NullValueHandling.Ignore)]
      public string VisibleUserIds { get; set; }

      [JsonProperty(PropertyName = "CUSTOMFIELDS", NullValueHandling = NullValueHandling.Ignore)]
      public CustomField[] CustomFields { get; set; }

      [JsonProperty(PropertyName = "ADDRESSES", NullValueHandling = NullValueHandling.Ignore)]
      public Address[] Addresses { get; set; }

      [JsonProperty(PropertyName = "CONTACTINFOS", NullValueHandling = NullValueHandling.Ignore)]
      public ContactInfo[] ContactInfos { get; set; }

      [JsonProperty(PropertyName = "DATES", NullValueHandling = NullValueHandling.Ignore)]
      public OrganizationDate[] Dates { get; set; }

      [JsonProperty(PropertyName = "TAGS", NullValueHandling = NullValueHandling.Ignore)]
      public Tag[] Tags { get; set; }

      [JsonProperty(PropertyName = "LINKS", NullValueHandling = NullValueHandling.Ignore)]
      public Link[] Links { get; set; }

      [JsonProperty(PropertyName = "ORGANISATIONLINKS", NullValueHandling = NullValueHandling.Ignore)]
      public OrganizationLink[] OrganizationLinks { get; set; }

      [JsonProperty(PropertyName = "EMAILLINKS", NullValueHandling = NullValueHandling.Ignore)]
      public EmailLink[] EmailLinks { get; set; }
   }
}