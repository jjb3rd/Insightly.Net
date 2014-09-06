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
    public class EmailLink
    {
        [JsonProperty(PropertyName = "EMAIL_LINK_ID")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "EMAIL_ID")]
        public int? EmailId { get; set; }

        [JsonProperty(PropertyName = "CONTACT_ID")]
        public int? ContactId { get; set; }

        [JsonProperty(PropertyName = "ORGANISATION_ID")]
        public int? OrganizationId { get; set; }

        [JsonProperty(PropertyName = "OPPORTUNITY_ID")]
        public int? OpportunityId { get; set; }

        [JsonProperty(PropertyName = "PROJECT_ID")]
        public int? ProjectId { get; set; }

    }
}
