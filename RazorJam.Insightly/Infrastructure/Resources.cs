/*
 * Razor Jam (razorjam.co.uk)
 *
 * Author:
 *  Elliot Chaim (elliot.chaim@razorjam.co.uk)
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

using RazorJam.Insightly.Models;
namespace RazorJam.Insightly.Infrastructure
{
   public static class Resources
   {
      public const string Comments = "Comments/";
      public const string Contacts = "Contacts/";
      public const string Countries = "Countries/";
      public const string Currencies = "Currencies/";
      public const string CustomFields = "CustomFields/";
      public const string Emails = "Emails/";
      public const string Events = "Events/";
      public const string FileAttachments = "FileAttachments/";
      public const string FileCategories = "FileCategories/";
      public const string Leads = "Leads/";
      public const string LeadSources = "LeadSources/";
      public const string LeadStatuses = "LeadStatuses/";
      public const string Notes = "Notes/";
      public const string Opportunities = "Opportunities/";
      public const string OpportunityCategories = "OpportunityCategories/";
      public const string OpportunityStateReasons = "OpportunityStateReasons/";
      public const string Organisations = "Organisations/";
      public const string Pipelines = "Pipelines/";
      public const string PipelineStages = "PipelineStages/";
      public const string Projects = "Projects";
      public const string ProjectCategories = "ProjectCategories/";
      public const string Relationships = "Relationships/";
      public const string Tags = "Tags/";
      public const string Tasks = "Tasks/";
      public const string TaskCategories = "TaskCategories/";
      public const string Teams = "Teams/";
      public const string TeamMembers = "TeamMembers/";
      public const string Users = "Users/";

      public static string Get<T>() where T : IInsightlyObject
      {
         var type = typeof(T);

         if (type == typeof(Comment)) return Comments;
         if (type == typeof(Contact)) return Contacts;
         if (type == typeof(Country)) return Countries;
         if (type == typeof(Currency)) return Currencies;
         if (type == typeof(CustomField)) return CustomFields;
         if (type == typeof(Email)) return Emails;
         if (type == typeof(Event)) return Events;
         if (type == typeof(FileAttachment)) return FileAttachments;
         if (type == typeof(FileCategory)) return FileCategories;
         if (type == typeof(Lead)) return Leads;
         if (type == typeof(LeadSource)) return LeadSources;
         if (type == typeof(LeadStatus)) return LeadStatuses;
         if (type == typeof(Note)) return Notes;
         if (type == typeof(Opportunity)) return Opportunities;
         if (type == typeof(OpportunityCategory)) return OpportunityCategories;
         if (type == typeof(OpportunityStateReason)) return OpportunityStateReasons;
         if (type == typeof(Organisation)) return Organisations;
         if (type == typeof(Pipeline)) return Pipelines;
         if (type == typeof(PipelineStage)) return PipelineStages;
         if (type == typeof(Project)) return Projects;
         if (type == typeof(ProjectCategory)) return ProjectCategories;
         if (type == typeof(Relationship)) return Relationships;
         if (type == typeof(Tag)) return Tags;
         if (type == typeof(Task)) return Tasks;
         if (type == typeof(TaskCategory)) return TaskCategories;
         if (type == typeof(Team)) return Teams;
         if (type == typeof(TeamMember)) return TeamMembers;
         if (type == typeof(User)) return Users;

         return null;
      }
   }
}
