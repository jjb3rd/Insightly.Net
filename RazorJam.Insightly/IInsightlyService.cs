namespace RazorJam.Insightly
{
   using System.Threading.Tasks;
   using System.Collections.Generic;

   public interface IInsightlyServiceWithResource<T> where T : IInsightlyObject
   {
      IInsightlyResponse<IEnumerable<T>> GetAll();
      IInsightlyResponse<T> Create(T data);
      IInsightlyResponse<T> Get(int id);
      IInsightlyResponse<T> Update(T data);
      IInsightlyResponse<bool> Delete(int id);
   }

   public interface IInsightlyService
   {
      //IInsightlyResponse<T> GetRequestCached<T>( string url );
      //Task<IInsightlyResponse<T>> DoRequest<T>(string url, string method, object body);
      IInsightlyServiceWithResource<T> With<T>(bool beta = false) where T : IInsightlyObject;
   }
}