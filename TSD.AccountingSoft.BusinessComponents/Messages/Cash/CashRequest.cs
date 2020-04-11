
using System;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business.Cash;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Cash
{

    /// <summary>
    /// class CashRequest
    /// </summary>
    public class CashRequest : RequestBase
    {

        /// <summary>
        /// Gets or sets the reference identifier.
        /// </summary>
        /// <value>
        /// The reference identifier.
        /// </value>
        public long RefId { get; set; }

        /// <summary>
        /// Gets or sets the reference identifier.
        /// </summary>
        /// <value>
        /// The reference identifier.
        /// </value>
        public string  RefNo  { get; set; } 

        /// <summary>
        /// Gets or sets the reference type identifier.
        /// </summary>
        /// <value>
        /// The reference type identifier.
        /// </value>
        public int RefTypeId { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public int Year { get; set; }   

        public DateTime DateMonth { get; set; }   

        public CashEntity CashEntity { get; set; }

        public bool isAutoGenerateParallel { get; set; }
    }
    
}
