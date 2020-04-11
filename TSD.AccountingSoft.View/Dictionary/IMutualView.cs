

using System;


namespace TSD.AccountingSoft.View.Dictionary
{

  public   interface IMutualView : IView
    {
         int MutualId { get; set; }


         string MutualCode { get; set; }


         string MutualName { get; set; }


         string JobCandidate { get; set; }


         string Address { get; set; }


         decimal Area { get; set; }

         int State { get; set; }

         int TotalFloor { get; set; }

         DateTime UseDate { get; set; }

         string Description { get; set; }

         bool IsActive { get; set; }
    }
}
