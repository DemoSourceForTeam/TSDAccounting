

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{

    /// <summary>
    /// IVendorsView interface
    /// </summary>
    public interface IVendorsView: IView
    {
        /// <summary>
        /// Sets the vendors.
        /// </summary>
        /// <value>
        /// The vendors.
        /// </value>
        IList<VendorModel> Vendors { set; }
    }
}
