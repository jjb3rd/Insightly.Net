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
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Insightly.Tests
{
    public static class Settings
    {
        // Replace these with your own values
        private const string apiKey = "00000000-0000-0000-0000-000000000000";
        private const int userIdForOperations = 0;
        private const int taskId = 0;
        private const int contactId = 0;


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Insightly"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Api")]
        public static string InsightlyApiKey { get { return apiKey; } }

        public static int NewTaskResponsibleUserId { get { return userIdForOperations; } }

        public static int NewTaskOwnerUserId { get { return userIdForOperations; } }

        public static int GetTaskId { get { return taskId; } }

        public static int GetContactId { get { return contactId; } }
    }
}