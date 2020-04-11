

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.System;


namespace TSD.AccountingSoft.View.System
{
    /// <summary>
    /// IUserProfilesView
    /// </summary>
    public interface IUserProfilesView : IView
    {
        /// <summary>
        /// Sets the user profiles.
        /// </summary>
        /// <value>
        /// The user profiles.
        /// </value>
        IList<UserProfileModel> UserProfiles { set; }
    }
}
