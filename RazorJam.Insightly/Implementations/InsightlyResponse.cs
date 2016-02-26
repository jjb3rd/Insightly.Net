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
 
 namespace RazorJam.Insightly.Implementations
{
   public class InsightlyResponse<T>: IInsightlyResponse<T>
   {
      private readonly int Status;
      private readonly T Data;

      public InsightlyResponse( int status, T result )
      {
         this.Status = status;
         this.Data = result;
      }

      public int ResponseStatus()
      {
         return this.Status;
      }

      public T ResponseData()
      {
         return this.Data;
      }
   }
}