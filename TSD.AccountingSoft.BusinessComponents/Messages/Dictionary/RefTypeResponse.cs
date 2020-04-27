

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;
using System.Collections.ObjectModel;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// RefTypeResponse
    /// </summary>
    public class RefTypeResponse : ResponseBase
    {
        /// <summary>
        /// The refTypes
        /// </summary>
        public ObservableCollection<RefTypeEntity> RefTypes;

        /// <summary>
        /// The refType
        /// </summary>
        public RefTypeEntity RefType;

        /// <summary>
        /// Gets or sets the refType identifier.
        /// </summary>
        /// <value>
        /// The refType identifier.
        /// </value>
        public long RefTypeId { get; set; }
    }
}
