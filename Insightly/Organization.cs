/*
 * Copyright 2014 Beckersoft, Inc.
 *
 * Author(s):
 *  John Becker (john@beckersoft.com)
 *  
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insightly
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Organization
    {
        [JsonProperty(PropertyName = "ORGANISATION_ID")]
        public int? Id { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty(PropertyName = "ORGANISATION_NAME")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "BACKGROUND")]
        public string Background { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings"), JsonProperty(PropertyName = "IMAGE_URL")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "OWNER_USER_ID")]
        public int? OwnerUserId { get; set; }

        [JsonConverter(typeof(InsightlyDateTimeConverter))]
        [JsonProperty(PropertyName = "DATE_CREATED_UTC")]
        public DateTime? DateCreatedUtc { get; set; }

        [JsonConverter(typeof(InsightlyDateTimeConverter))]
        [JsonProperty(PropertyName = "DATE_UPDATED_UTC")]
        public DateTime? DateUpdatedUtc { get; set; }

        [JsonProperty(PropertyName = "VISIBLE_TO")]
        public string VisibleTo { get; set; }

        [JsonProperty(PropertyName = "VISIBLE_TEAM_ID")]
        public int? VisibleTeamId { get; set; }

        [JsonProperty(PropertyName = "VISIBLE_USER_IDS")]
        public string VisibleUserIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), JsonProperty(PropertyName = "CUSTOMFIELDS")]
        public CustomField[] CustomFields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), JsonProperty(PropertyName = "ADDRESSES")]
        public Address[] Addresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos"), JsonProperty(PropertyName = "CONTACTINFOS")]
        public ContactInfo[] ContactInfos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), JsonProperty(PropertyName = "DATES")]
        public OrganizationDate[] Dates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), JsonProperty(PropertyName = "TAGS")]
        public Tag[] Tags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), JsonProperty(PropertyName = "LINKS")]
        public Link[] Links { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), JsonProperty(PropertyName = "ORGANISATIONLINKS")]
        public OrganizationLink[] OrganizationLinks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays"), JsonProperty(PropertyName = "EMAILLINKS")]
        public EmailLink[] EmailLinks { get; set; }
    }
}
