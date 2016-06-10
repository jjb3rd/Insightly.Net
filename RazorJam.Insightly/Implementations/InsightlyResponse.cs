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