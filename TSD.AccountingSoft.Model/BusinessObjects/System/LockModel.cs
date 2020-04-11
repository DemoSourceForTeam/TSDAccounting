using System;
namespace TSD.AccountingSoft.Model.BusinessObjects.System
{
    /// <summary>
    /// class LockModel
    /// </summary>
    public class LockModel
    {
        public string Content { get; set; }

        public DateTime LockDate { get; set; }

        public bool IsLock { get; set; }

    }
}
