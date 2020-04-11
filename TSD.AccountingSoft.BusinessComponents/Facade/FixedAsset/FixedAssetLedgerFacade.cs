using System.Linq;
using TSD.AccountingSoft.BusinessComponents.Messages.FixedAsset;
using TSD.AccountingSoft.DataAccess.IEntitiesDao.FixedAsset;


namespace TSD.AccountingSoft.BusinessComponents.Facade.FixedAsset
{
    /// <summary>
    /// class FixedAssetLedgerFacade
    /// </summary>
    public class FixedAssetLedgerFacade
    {
        /// <summary>
        /// The fixed asset ledger DAO
        /// </summary>
        private static readonly IFixedAssetLedgerDao FixedAssetLedgerDao = DataAccess.DataAccess.FixedAssetLedgerDao;

        /// <summary>
        /// Gets the fixed asset ledgers.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public FixedAssetLedgerResponse GetFixedAssetLedgers(FixedAssetLedgerRequest request)
        {
            var response = new FixedAssetLedgerResponse();
            if (request.LoadOptions.Contains("FixedAssetLedgers"))
            {
                if (request.LoadOptions.Contains("FixedAssetId"))
                    response.FixedAssetLedgers = FixedAssetLedgerDao.GetFixedAssetLedgerByFixedAssetId(request.FixedAssetId);
            }
            return response;
        }
    }
}
