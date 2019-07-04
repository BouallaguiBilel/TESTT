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
    [XafDefaultProperty("ItemCode")]
    [XafDisplayName("Items Listing")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Item : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Item(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
            IsActive = true;
            MinStock = 1;
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

        private string _ItemCode;
        [XafDisplayName("Item Code"), ToolTip("Enter Text")]
        [ Index(0), VisibleInListView(true),VisibleInDetailView(true)]
        [ RuleRequiredField(DefaultContexts.Save)]
        public string CustomerCode
        {
            get { return _ItemCode; }
            set { SetPropertyValue("PersistentProperty", ref _ItemCode, value); }
        }

        private string _ItemName;
        [XafDisplayName("Item Name"), ToolTip("Enter Text")]
        [Index(1), VisibleInListView(true), VisibleInDetailView(true)]
        [RuleRequiredField(DefaultContexts.Save)]
        public string ItemName
        {
            get { return _ItemName; }
            set { SetPropertyValue("PersistentProperty", ref _ItemName, value); }
        }

        private decimal _ItemPrice;
        [XafDisplayName("Item Price"), ToolTip("Enter Price")]
        [Index(2), VisibleInListView(true), VisibleInDetailView(true)]
        //[RuleRequiredField(DefaultContexts.Save)]
        public decimal ItemPrice
        {
            get { return _ItemPrice; }
            set { SetPropertyValue("PersistentProperty", ref _ItemPrice, value); }
        }

        private double _MinStock;
        [XafDisplayName("Min Stock"), ToolTip("Enter Stock")]
        [Index(2), VisibleInListView(true), VisibleInDetailView(true)]
        //[RuleRequiredField(DefaultContexts.Save)]
        public double MinStock
        {
            get { return _MinStock; }
            set { SetPropertyValue("PersistentProperty", ref _MinStock, value); }
        }

        private bool _IsActive;
        [XafDisplayName("Is Active"), ToolTip("Enter Stock")]
        [Index(2), VisibleInListView(true), VisibleInDetailView(true)]
        //[RuleRequiredField(DefaultContexts.Save)]
        public bool IsActive
        {
            get { return _IsActive; }
            set { SetPropertyValue("PersistentProperty", ref _IsActive, value); }
        }
    }
}