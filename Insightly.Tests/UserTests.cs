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
using System.Diagnostics;

namespace Insightly.Tests
{
    [TestClass]
    public class UserTests
    {

        Insightly.InsightlyService insightlyService = new Insightly.InsightlyService(Settings.InsightlyApiKey);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Insightly"), TestMethod]
        public void TestInsightlyGetUsers()
        {
            IEnumerable<Insightly.User> users = insightlyService.Users;
            Assert.IsNotNull(users);
            foreach(Insightly.User user in users)
            {
                Assert.IsNotNull(user);
            }

        }
    }
}
