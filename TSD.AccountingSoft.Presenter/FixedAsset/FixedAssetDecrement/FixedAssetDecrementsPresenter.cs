

using TSD.AccountingSoft.View.FixedAsset;


namespace TSD.AccountingSoft.Presenter.FixedAsset.FixedAssetDecrement
{
    /// <summary>
    /// class FixedAssetDecrementsPresenter
    /// </summary>
    public class FixedAssetDecrementsPresenter : Presenter<IFixedAssetDecrementsView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedAssetDecrementsPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public FixedAssetDecrementsPresenter(IFixedAssetDecrementsView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays the by year.
        /// </summary>
        public void Display()
        {
            View.FixedAssetDecrements = Model.GetFixedAssetDecrements();
        }

        /// <summary>
        /// Displays the by year.
        /// </summary>
        /// <param name="refDate">The post date.</param>
        public void Display(string refDate)
        {
            View.FixedAssetDecrements = Model.GetFixedAssetDecrementsByYearOfPostDate( refDate);
        }

        /// <summary>
        /// Displays the voucher detail.
        /// LinhMC add 30.9.2016
        /// </summary>
        /// <param name="refId">The reference identifier.</param>
        public void DisplayVoucherDetail(long refId)
        {
            var voucher = Model.GetFixedAssetDecrement(refId);
            if (voucher != null)
            {
                View.FixedAssetDecrementDetails = voucher.FixedAssetDecrementDetails;
            }
        }
    }
}
