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
            if (Session.FindObject<Contact>(CriteriaOperator.Parse(
            "FirstName == 'John' && LastName == 'Doe'")) == null)
            {
                Contact contact = new Contact(Session);
                contact.FirstName = "John";
                contact.LastName = "Doe";
                contact.Save();

                contact = new Contact(Session);
                contact.FirstName = "Jesse";
                contact.LastName = "Black";
                contact.Save();

                contact = new Contact(Session);
                contact.FirstName = "Sam";
                contact.LastName = "Brown";
                contact.Save();

                contact = new Contact(Session);
                contact.FirstName = "Ann";
                contact.LastName = "Grant";
                contact.Save();

            }

        }
    }
}
