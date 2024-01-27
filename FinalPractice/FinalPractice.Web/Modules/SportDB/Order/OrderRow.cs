
namespace FinalPractice.SportDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("SportDB"), TableName("[spt].[Order]")]
    [DisplayName("Order"), InstanceName("Order")]

    //Permision Only read
    [ReadPermission(PermissionKeys.Customer.View)]

    [ModifyPermission("Administration:General")]
    public sealed class OrderRow : Row, IIdRow
    {
        [DisplayName("Order Id"), Identity]
        public Int32? OrderId
        {
            get { return Fields.OrderId[this]; }
            set { Fields.OrderId[this] = value; }
        }

        [DisplayName("Customer"), NotNull, ForeignKey(typeof(CustomerRow), "CustomerId"), LeftJoin("jCutormer"), TextualField("Fullname")]

        //Lookup Customer
        [LookupEditor(typeof(CustomerRow))]
        public Int32? CutormerId
        {
            get { return Fields.CutormerId[this]; }
            set { Fields.CutormerId[this] = value; }
        }
        // Order Status (In Progress, In to deliver or Delivered)
        [DisplayName("Status"), NotNull, DefaultValue(1),QuickFilter]
        [Width(100)]
        public OrderStatus? Status
        {
            get { return (OrderStatus?)Fields.Status[this]; }
            set { Fields.Status[this] = (Int32?)value; }
        }
        // show cities (santo domingo, azua,...)
        [Description("Ship City"),DefaultValue(1),QuickFilter]
        [Width(120)]
        public OrderCity? ShipCity
        {
            get { return (OrderCity?)Fields.ShipCity[this]; }
            set { Fields.ShipCity[this] = (Int32?)value; }
        }

        [DisplayName("Order Date"),DefaultValue(1), QuickFilter]
        public DateTime? ReleaseDate
        {
            get { return Fields.ReleaseDate[this]; }
            set { Fields.ReleaseDate[this] = value; }
        }

        [DisplayName("Cutormer Firstname"), Expression("jCutormer.[Firstname]")]
        public String CutormerFirstname
        {
            get { return Fields.CutormerFirstname[this]; }
            set { Fields.CutormerFirstname[this] = value; }
        }

        [DisplayName("Cutormer Lastname"), Expression("jCutormer.[Lastname]")]
        public String CutormerLastname
        {
            get { return Fields.CutormerLastname[this]; }
            set { Fields.CutormerLastname[this] = value; }
        }

        //Concat customer first name and last name
        [DisplayName("Customer FullName")]
        [Expression("(jCutormer.[Firstname] + ' ' + jCutormer.[Lastname])")]

        public String CustomerFullname
        {
            get { return Fields.CustomerFullname[this]; }
            set { Fields.CustomerFullname[this] = value; }
        }

        [DisplayName("Cutormer Gender"), Expression("jCutormer.[Gender]")]
        public Int32? CutormerGender
        {
            get { return Fields.CutormerGender[this]; }
            set { Fields.CutormerGender[this] = value; }
        }

        // list of products (use only in OrderForm)

        [DisplayName("Product List"), NotMapped]
        [MasterDetailRelation(foreignKey: "OrderId", IncludeColumns = "ProductName,LineTotal")]

        public List<OrderDetailsRow> ProductList
        {
            get { return Fields.ProductList[this]; }
            set { Fields.ProductList[this] = value; }
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.OrderId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OrderRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderId;
            public Int32Field CutormerId;
            public Int32Field Status;
            public Int32Field ShipCity;
            public DateTimeField ReleaseDate;
            public ListField<OrderDetailsRow> ProductList;

            public StringField CutormerFirstname;
            public StringField CutormerLastname;
            public StringField CustomerFullname;
            public Int32Field CutormerGender;
        }
    }
}
