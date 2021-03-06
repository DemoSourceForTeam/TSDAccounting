﻿

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;
using TSD.AccountingSoft.View.Dictionary;

namespace TSD.AccountingSoft.Presenter.Dictionary.AutoNumber
{
    public class AutoNumbersPresenter : Presenter<IAutoNumbersView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoNumbersPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public AutoNumbersPresenter(IAutoNumbersView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.AutoNumbers = Model.GetAutoNumbers();
        }

        public string Save()
        {
            var autoNumbers = View.AutoNumbers;
            return Model != null ? Model.UpdateAutoNumbers((List<AutoNumberModel>)autoNumbers) : null;
        }
    }
}
