

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report.Voucher;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Report
{
    /// <summary>
    /// C30BBResponse
    /// </summary>
  public  class C30BBResponse: ResponseBase
    {
        /// <summary>
        /// The C30 bb repport lists
        /// </summary>
      public List<C30BBEntity> C30BBRepportLists;

    }
}
