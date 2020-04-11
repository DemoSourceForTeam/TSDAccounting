

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Business;

namespace TSD.AccountingSoft.DataAccess.IEntitiesDao
{
    public interface ISupplyLedgerDao
    {
        SupplyLedgerEntity GetSupplyLedgerByRefId(long refId, int refTypeId);
        SupplyLedgerEntity GetSupplyLedgerByInventoryItemId(int inventoryItemId, int refTypeId);
        List<SupplyLedgerEntity> GetSupplyLedgerByInventoryItemId(int inventoryItemId);
        long InsertSupplyLedger(SupplyLedgerEntity supplyLedger);
        string DeleteSupplyLedgerByRefId(long refId, int refTypeId);
        string DeleteSupplyLedgerByRefId(long refId);
        string DeleteSupplyLedgerByOPN();
        string DeleteSupplyLedgerByInventoryItemId(int inventoryItemId, int refTypeId);
    }
}
