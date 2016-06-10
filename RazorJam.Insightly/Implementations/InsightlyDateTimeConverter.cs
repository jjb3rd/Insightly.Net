namespace RazorJam.Insightly.Implementations
{
   using Newtonsoft.Json.Converters;

   class InsightlyDateTimeConverter : IsoDateTimeConverter
   {
      public InsightlyDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss"; }
   }
}