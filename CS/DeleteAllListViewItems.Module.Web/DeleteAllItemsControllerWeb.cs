using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using System.Collections;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.Data.Filtering;

namespace DeleteAllListViewItems.Module
{
    public partial class DeleteAllItemsController : ViewController
    {
        public DeleteAllItemsController()
        {
            InitializeComponent();
            RegisterActions(components);
            this.TargetViewType = ViewType.ListView;
        }


        protected override void OnActivated()
        {
            base.OnActivated();
            UpdateActionState();
            View.SelectionChanged += new EventHandler(ObjectChanged);
            View.CurrentObjectChanged += new EventHandler(ObjectChanged);
        }

        void ObjectChanged(object sender, EventArgs e)
        {
            UpdateActionState();
        }


        private void UpdateActionState()
        {
            Type type = ((ListView)View).ObjectTypeInfo.Type;
            this.simpleAction1.Enabled.SetItemValue("ItemsCount", View.ObjectSpace.GetObjects(type).Count > 0);
        }


        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            ASPxGridListEditor listEditor = ((ListView)View).Editor as ASPxGridListEditor;
            if (listEditor != null)
            {

                using (ObjectSpace objectSpace = Application.CreateObjectSpace())
                {
                    ArrayList objectsToDelete = new ArrayList();
                    Type type = ((ListView)View).ObjectTypeInfo.Type;
                    objectsToDelete.AddRange(objectSpace.GetObjects(type, CriteriaOperator.Parse(listEditor.Grid.FilterExpression)));
                    objectSpace.Delete(objectsToDelete);
                    objectSpace.CommitChanges();
                }
                ObjectSpace.Refresh();
                UpdateActionState();
            }
        }
    }
}
