

namespace TSD.AccountingSoft.BusinessEntities.Dictionary
{
    public class AutoNumberListEntity : BusinessEntities
    {

      public AutoNumberListEntity()
        {
          
        }

      public AutoNumberListEntity(string tableCode, string tableName, string prefix, string suffix, int value, int lengthOfValue)
        {
            TableCode = tableCode;
            TableName = tableName;
            Prefix = prefix;
            Suffix = suffix;
            Value = value;
            LengthOfValue = lengthOfValue;
        }

      public string TableCode { get; set; }
      public string TableName { get; set; }
      public string Prefix { get; set; }
      public string Suffix { get; set; }
      public int Value { get; set; }
      public int LengthOfValue { get; set; }

    }
}
