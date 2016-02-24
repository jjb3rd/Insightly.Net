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

 namespace RazorJam.Insightly
{
   using System.Threading.Tasks;
   using System.Collections.Generic;

   public interface IInsightlyService
   {
      object GetRequestCached<T>( string url );
      Task<T> DoRequest<T>( string url, string method, object body );
      IInsightlyService With( string resource );
      IEnumerable<IInsightlyObject> GetAll<IInsightlyObject>();
      IInsightlyObject Create( IInsightlyObject data );
      IInsightlyObject Get<IInsightlyObject>(int id);
      IInsightlyObject Update<IInsightlyObject>( IInsightlyObject data );
      bool Delete();
   }
}