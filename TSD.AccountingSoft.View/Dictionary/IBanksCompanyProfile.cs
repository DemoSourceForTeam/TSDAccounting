
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;
using System.Collections.Generic;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// ICompanyProfilesView
    /// </summary>
    public interface ICompanyProfilesView : IView
    {
        /// <summary>
        /// Sets the companyProfiles.
        /// </summary>
        /// <value>
        /// The companyProfiles.
        /// </value>
        IList<CompanyProfileModel> CompanyProfiles { set; }
    }
}