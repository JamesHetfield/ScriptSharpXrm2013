using System;
using System.Collections.Generic;
using System.Linq;

namespace Xrm
{

    public delegate bool GetAttributeHandler(Attribute attribute, int index);
    public delegate bool GetControlHandler(Control control, int index);
    public delegate bool GetNavigationItemHandler(NavigationItem item, int index);
    public delegate bool GetFormSelectorItemHandler(FormSelectorItem item, int index);
    public delegate bool GetTabItemHandler(TabItem tab, int index);
    public delegate bool GetTabSectionHandler(TabSection section, int index);
    public delegate void AddRemoveOnSaveHandler(ExecutionContext context);
    public delegate void AddRemoveOnChangeHandler();

    public delegate void OnCloseCallbackHandler();
    public delegate void YesCloseCallbackHandler();
    public delegate void NoCloseCallbackHandler();

    public delegate void AddPreSearchHandler();
    public delegate void RemovePreSearchHandler();

    public delegate void SuccessCallbackHandler();
    public delegate void ErrorCallbackHandler(int errorCode, string message);

}
