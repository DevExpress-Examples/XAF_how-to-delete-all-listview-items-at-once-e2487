using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace DeleteAllListViewItems.Module
{
    public class Updater : ModuleUpdater
    {
        public Updater(DevExpress.ExpressApp.IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();
            if (ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse(
            "FirstName == 'John' && LastName == 'Doe'")) == null)
            {
                Contact contact = ObjectSpace.CreateObject<Contact>();
                contact.FirstName = "John";
                contact.LastName = "Doe";


                contact = ObjectSpace.CreateObject<Contact>();
                contact.FirstName = "Jesse";
                contact.LastName = "Black";


                contact = ObjectSpace.CreateObject<Contact>();
                contact.FirstName = "Sam";
                contact.LastName = "Brown";

                contact = ObjectSpace.CreateObject<Contact>();
                contact.FirstName = "Ann";
                contact.LastName = "Grant";

            }

        }
    }
}
