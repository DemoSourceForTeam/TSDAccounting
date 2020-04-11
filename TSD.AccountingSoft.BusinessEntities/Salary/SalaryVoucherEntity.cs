


namespace TSD.AccountingSoft.BusinessEntities.Salary
{
  public  class SalaryVoucherEntity
    {
      public int RefTypeId { get; set; }
      public string RefNo { get; set; }
      public string PostedDate { get; set; }
      public string CurrencyCode { get; set; }
      public decimal ExchangeRate { get; set; }

    }
}
