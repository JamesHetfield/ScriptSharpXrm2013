using System;
using System.Runtime.CompilerServices;

namespace Xrm
{

    /// <summary>
    /// Represents a FormType enumeration.
    /// </summary>
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
        [Obsolete("Deprecated as of CRM 2011", false)]
        QuickCreate = 5,
        BulkEdit = 6,
        [Obsolete("Deprecated as of CRM 2013", false)]
        ReadOptimized = 11
    }

}