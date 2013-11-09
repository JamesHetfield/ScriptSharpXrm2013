using System;
using System.Runtime.CompilerServices;

namespace Xrm
{
    [IgnoreNamespace]
    [Imported]
    [NumericValues]
    public enum SaveMode
    {
        Save = 1,
        SaveAndClose = 2,
        SaveAndNew = 59,
        AutoSave = 70,
        SaveAsCompleted = 58,
        Deactivate = 5,
        Reactivate = 6,
        Assign = 47,
        Send = 7,
        Qualify = 16,
        Disqualify = 16
    }
}
