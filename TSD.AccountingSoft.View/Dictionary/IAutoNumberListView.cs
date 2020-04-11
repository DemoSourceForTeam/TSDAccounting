

namespace TSD.AccountingSoft.View.Dictionary
{
   public class IAutoNumberListView
    {

      public  string TableCode { get; set; }
      public  string TableName { get; set; }
      public  string Prefix { get; set; }
      public  string Suffix { get; set; }
      public int Value { get; set; }
      public int LengthOfValue { get; set; }
    }
}
