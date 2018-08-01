﻿using System.Web.UI;
using ClientDependency.Core;

namespace Umbraco.Web.UI.Bundles
{
    /// <summary>
    /// The core Jquery libs
    /// </summary>
    [ClientDependency(ClientDependencyType.Javascript, "modal/jquery.simplemodal.1.4.1.custom.js", "UmbracoClient", Priority = 2, Group = 4)]
    [ClientDependency(ClientDependencyType.Javascript, "Application/JQuery/jquery.metadata.min.js", "UmbracoClient", Priority = 4, Group = 4)]
    [ClientDependency(ClientDependencyType.Javascript, "Application/jQuery/jquery.hotkeys.js", "UmbracoClient", Priority = 5, Group = 4)]
    public class JsJQueryPlugins : Control
    {
    }
}
