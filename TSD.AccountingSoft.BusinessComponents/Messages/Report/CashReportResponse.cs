

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report.Finacial;



namespace TSD.AccountingSoft.BusinessComponents.Messages.Report
{
    /// <summary>
    /// Class CashReportResponse.
    /// </summary>
  public  class CashReportResponse: ResponseBase
    {
        /// <summary>
        /// The cash repport lists
        /// </summary>
      public List<CashReportEntity> CashRepportLists;

    }
}
