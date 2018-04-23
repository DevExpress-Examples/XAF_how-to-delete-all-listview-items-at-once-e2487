using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace DeleteAllListViewItems.Module
{
    [DefaultClassOptions]
    public class Contact : BaseObject
    {
        public Contact(Session session) : base(session) { }
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                SetPropertyValue("FirstName", ref firstName, value);
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                SetPropertyValue("LastName", ref lastName, value);
            }
        }
    }



}
