using System;
using System.Runtime.CompilerServices;

namespace Xrm
{

    [IgnoreNamespace]
    [Imported]
    [NumericValues]
    public enum FormType
    {

        Undefined = 0,
        Create = 1,
        Update = 2,
        ReadOnly = 3,
        Disabled = 4,
        [ObsoleteAttribute("Deprecated")]
        QuickCreate = 5,
        BulkEdit = 6,
        [ObsoleteAttribute("Deprecated")]
        ReadOptimized = 11

    }

}