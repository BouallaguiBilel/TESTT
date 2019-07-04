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
    [NavigationItem("setup")]
    [XafDefaultProperty("Costomer Code")]
    [XafDisplayName("Costomer Listing")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Customer : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Customer(Session session)
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

        private string _CustomerCode;
        [XafDisplayName("Costomer Code"), ToolTip("Enter Text")]
        [ Index(0), VisibleInListView(true),VisibleInDetailView(true)]
        [ RuleRequiredField(DefaultContexts.Save)]
        public string CustomerCode
        {
            get { return _CustomerCode; }
            set { SetPropertyValue("PersistentProperty", ref _CustomerCode, value); }
        }

        private string _CustomerName;
        [XafDisplayName("Costomer Name"), ToolTip("Enter Text")]
        [Index(1), VisibleInListView(true), VisibleInDetailView(true)]
        [RuleRequiredField(DefaultContexts.Save)]
        public string CustomerName
        {
            get { return _CustomerName; }
            set { SetPropertyValue("PersistentProperty", ref _CustomerName, value); }
        }

        private string _ContactPerson;
        [XafDisplayName("Contact Person"), ToolTip("Enter Text")]
        [Index(2), VisibleInListView(true), VisibleInDetailView(true)]
        //[RuleRequiredField(DefaultContexts.Save)]
        public string ContactPerson
        {
            get { return _ContactPerson; }
            set { SetPropertyValue("PersistentProperty", ref _ContactPerson, value); }
        }
    }
}