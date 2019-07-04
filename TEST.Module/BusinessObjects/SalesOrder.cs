using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace TEST.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class SalesOrder : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public SalesOrder(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue("PersistentProperty", ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}

        private int _DocNum;
        [XafDisplayName("Document No"), ToolTip("Enter Doc No")]
        [Index(0), VisibleInListView(true), VisibleInDetailView(true)]
        [RuleRequiredField(DefaultContexts.Save)]
        public int DocNum
        {
            get { return _DocNum; }
            set { SetPropertyValue("PersistentProperty", ref _DocNum, value); }
        }

        private DateTime _DocDate;
        [XafDisplayName("Document Date"), ToolTip("Enter Doc Date")]
        [Index(0), VisibleInListView(true), VisibleInDetailView(true)]
        [RuleRequiredField(DefaultContexts.Save)]
        public DateTime DocDate
        {
            get { return _DocDate; }
            set { SetPropertyValue("PersistentProperty", ref _DocDate, value); }
        }

        private Customer _Customer;
        [XafDisplayName("Document Date"), ToolTip("Enter Doc Date")]
        [Index(0), VisibleInListView(true), VisibleInDetailView(true)]
        [RuleRequiredField(DefaultContexts.Save)]
        public Customer Customer
        {
            get { return _Customer; }
            set { SetPropertyValue("PersistentProperty", ref _Customer, value); }
        }





    }
}