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
using System.Diagnostics;

namespace Insightly.Tests
{
    [TestClass]
    public class TaskTests
    {
        Insightly.InsightlyService insightlyService = new Insightly.InsightlyService(Settings.InsightlyApiKey);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Insightly"), TestMethod]
        public void TestInsightlyCreateTask()
        {
            Insightly.Task task = insightlyService.CreateTask(new Insightly.Task()
            {
                Title = "ACME Corporation New Customer Signup Introduction",
                Details = "ACME Corporation has just signed up for our great app and need signup documents.",
                Priority = 2,
                Status = "NOT STARTED",
                PubliclyVisible = true,
                Completed = false,
                ResponsibleUserId = Settings.NewTaskResponsibleUserId,
                OwnerUserId = Settings.NewTaskOwnerUserId,
                OwnerVisible = true
            });
            Assert.IsNotNull(task);
            Assert.IsNotNull(task.Id);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Insightly"), TestMethod]
        public void TestInsightlyGetTask()
        {
            Insightly.Task task = insightlyService.GetTask(Settings.GetTaskId);
            Assert.IsNotNull(task);
            Debug.Write(task);
        }
    }
}
