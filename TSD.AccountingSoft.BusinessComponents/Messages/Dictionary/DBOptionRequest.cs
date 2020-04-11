

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// DBOptionRequest
    /// </summary>
    public class DBOptionRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the database option identifier.
        /// </summary>
        /// <value>
        /// The database option identifier.
        /// </value>
        public string DBOptionId { get; set; }

        /// <summary>
        /// The database option
        /// </summary>
        public DBOptionEntity DBOption;

        /// <summary>
        /// The database options
        /// </summary>
        public IList<DBOptionEntity> DBOptions;

        /// <summary>
        /// Gets or sets the type of the value.
        /// </summary>
        /// <value>
        /// The type of the value.
        /// </value>
        public int ValueType { get; set; }
    }
}
