<!-- default file list -->
*Files to look at*:

* [DeleteAllItemsControllerWeb.cs](./CS/DeleteAllListViewItems.Module.Web/DeleteAllItemsControllerWeb.cs) (VB: [DeleteAllItemsControllerWeb.vb](./VB/DeleteAllListViewItems.Module.Web/DeleteAllItemsControllerWeb.vb))
* [Model.DesignedDiffs.xafml](./CS/DeleteAllListViewItems.Module.Web/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/DeleteAllListViewItems.Module.Web/Model.DesignedDiffs.xafml))
* [Updater.cs](./CS/DeleteAllListViewItems.Module.Web/Updater.cs) (VB: [Updater.vb](./VB/DeleteAllListViewItems.Module.Web/Updater.vb))
* [WebModule.cs](./CS/DeleteAllListViewItems.Module.Web/WebModule.cs) (VB: [WebModule.vb](./VB/DeleteAllListViewItems.Module.Web/WebModule.vb))
* [DeleteAllItemsControllerWin.cs](./CS/DeleteAllListViewItems.Module.Win/DeleteAllItemsControllerWin.cs) (VB: [DeleteAllItemsControllerWin.vb](./VB/DeleteAllListViewItems.Module.Win/DeleteAllItemsControllerWin.vb))
* [Model.DesignedDiffs.xafml](./CS/DeleteAllListViewItems.Module.Win/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/DeleteAllListViewItems.Module.Win/Model.DesignedDiffs.xafml))
* [Updater.cs](./CS/DeleteAllListViewItems.Module.Win/Updater.cs) (VB: [Updater.vb](./VB/DeleteAllListViewItems.Module.Win/Updater.vb))
* [WinModule.cs](./CS/DeleteAllListViewItems.Module.Win/WinModule.cs) (VB: [WinModule.vb](./VB/DeleteAllListViewItems.Module.Win/WinModule.vb))
* [CodeCentralExampleInMemoryDataStoreProvider.cs](./CS/DeleteAllListViewItems.Module/CodeCentralExampleInMemoryDataStoreProvider.cs) (VB: [CodeCentralExampleInMemoryDataStoreProvider.vb](./VB/DeleteAllListViewItems.Module/CodeCentralExampleInMemoryDataStoreProvider.vb))
* [Contact.cs](./CS/DeleteAllListViewItems.Module/Contact.cs) (VB: [Contact.vb](./VB/DeleteAllListViewItems.Module/Contact.vb))
* [Model.DesignedDiffs.xafml](./CS/DeleteAllListViewItems.Module/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/DeleteAllListViewItems.Module/Model.DesignedDiffs.xafml))
* [Module.cs](./CS/DeleteAllListViewItems.Module/Module.cs) (VB: [Module.vb](./VB/DeleteAllListViewItems.Module/Module.vb))
* [Updater.cs](./CS/DeleteAllListViewItems.Module/Updater.cs) (VB: [Updater.vb](./VB/DeleteAllListViewItems.Module/Updater.vb))
* [WebApplication.cs](./CS/DeleteAllListViewItems.Web/ApplicationCode/WebApplication.cs) (VB: [WebApplication.vb](./VB/DeleteAllListViewItems.Web/ApplicationCode/WebApplication.vb))
* [Default.aspx](./CS/DeleteAllListViewItems.Web/Default.aspx) (VB: [Default.aspx.vb](./VB/DeleteAllListViewItems.Web/Default.aspx.vb))
* [Default.aspx.cs](./CS/DeleteAllListViewItems.Web/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/DeleteAllListViewItems.Web/Default.aspx.vb))
* [Error.aspx](./CS/DeleteAllListViewItems.Web/Error.aspx) (VB: [Error.aspx](./VB/DeleteAllListViewItems.Web/Error.aspx))
* [Error.aspx.cs](./CS/DeleteAllListViewItems.Web/Error.aspx.cs) (VB: [Error.aspx](./VB/DeleteAllListViewItems.Web/Error.aspx))
* [Global.asax](./CS/DeleteAllListViewItems.Web/Global.asax) (VB: [Global.asax](./VB/DeleteAllListViewItems.Web/Global.asax))
* [Global.asax.cs](./CS/DeleteAllListViewItems.Web/Global.asax.cs) (VB: [Global.asax](./VB/DeleteAllListViewItems.Web/Global.asax))
* [Login.aspx](./CS/DeleteAllListViewItems.Web/Login.aspx) (VB: [Login.aspx](./VB/DeleteAllListViewItems.Web/Login.aspx))
* [Login.aspx.cs](./CS/DeleteAllListViewItems.Web/Login.aspx.cs) (VB: [Login.aspx](./VB/DeleteAllListViewItems.Web/Login.aspx))
* [Model.xafml](./CS/DeleteAllListViewItems.Web/Model.xafml) (VB: [Model.xafml](./VB/DeleteAllListViewItems.Web/Model.xafml))
* [WebApplication.cs](./CS/DeleteAllListViewItems.Web/WebApplication.cs) (VB: [WebApplication.vb](./VB/DeleteAllListViewItems.Web/WebApplication.vb))
* [Model.xafml](./CS/DeleteAllListViewItems.Win/Model.xafml) (VB: [Model.xafml](./VB/DeleteAllListViewItems.Win/Model.xafml))
* [Program.cs](./CS/DeleteAllListViewItems.Win/Program.cs) (VB: [Program.vb](./VB/DeleteAllListViewItems.Win/Program.vb))
* [WinApplication.cs](./CS/DeleteAllListViewItems.Win/WinApplication.cs) (VB: [WinApplication.vb](./VB/DeleteAllListViewItems.Win/WinApplication.vb))
<!-- default file list end -->
# How to delete all ListView items at once


<p>This example illustrates the capability to clear the actual ListView content programmatically. It's recommended to create a separate ObjectSpace instance for this purpose (please check the DeleteAllItemsController implementation in the platform-independent DeleteAllListViewItems.Module). The "Delete All" action is enabled automatically, depending on the ListView content. In addition, the actual filter expression applied to the ListView is taken into account.</p>

<br/>


