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
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Insightly.Tests
{
    [TestClass]
    public class ContactTests
    {
        Insightly.InsightlyService insightlyService = new Insightly.InsightlyService(Settings.InsightlyApiKey);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Insightly"), TestMethod]
        public void TestInsightlyCreateContact()
        {
            Insightly.Contact contact = insightlyService.CreateContact(new Insightly.Contact("Wil e Coyote")
            {
                FirstName = "Wil e",
                LastName = "Coyote",
                ContactInfos = new List<Insightly.ContactInfo>(new Insightly.ContactInfo[]{
                        new Insightly.ContactInfo(){
                            ContactType = "Phone",
                            Label = "Work",
                            Detail = "(555) 867-5309"
                        },
                        new Insightly.ContactInfo(){
                            ContactType = "Email",
                            Label = "Work",
                            Detail = "wilecoyote@acme.com"
                        }
                    })
            });
            Assert.IsNotNull(contact);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Insightly"), TestMethod]
        public void TestInsightlyGetContact()
        {
            Insightly.Contact contact = insightlyService.GetContact(Settings.GetContactId);
            Assert.IsNotNull(contact);
            Assert.IsNotNull(contact.Id);

        }
    }
}
