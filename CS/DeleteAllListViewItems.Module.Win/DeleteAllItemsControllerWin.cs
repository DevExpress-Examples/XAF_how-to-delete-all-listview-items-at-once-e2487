using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using System.Collections;
using DevExpress.ExpressApp.Win.Editors;
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
            GridListEditor editor = (View as ListView).Editor as GridListEditor;
            if (editor != null)
            {
                using (ObjectSpace objectSpace = Application.CreateObjectSpace())
                {
                    ArrayList objectsToDelete = new ArrayList();
                    Type type = ((ListView)View).ObjectTypeInfo.Type;
                    objectsToDelete.AddRange(objectSpace.GetObjects(type, editor.GridView.ActiveFilterCriteria));
                    objectSpace.Delete(objectsToDelete);
                    objectSpace.CommitChanges();
                }
                ObjectSpace.Refresh();
                UpdateActionState();
            }
        }
    }
}
