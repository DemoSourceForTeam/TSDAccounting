

using System;

namespace TSD.AccountingSoft.View.System
{

    public interface ILockView
    {
        string Content { get; set; }

        DateTime LockDate { get; set; }

        bool IsLock { get; set; }
    }
}
