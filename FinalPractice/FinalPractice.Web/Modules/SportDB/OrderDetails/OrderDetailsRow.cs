
namespace FinalPractice.SportDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("SportDB"), TableName("[spt].[OrderDetails]")]
    [DisplayName("Order Details"), InstanceName("Order Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("SportDB.OrderDetalis")]
    public sealed class OrderDetailsRow : Row, IIdRow
    {
        [DisplayName("Order Details Id"), Identity]
        public Int32? OrderDetailsId
        {
            get { return Fields.OrderDetailsId[this]; }
            set { Fields.OrderDetailsId[this] = value; }
        }
        [DisplayName("Order"), NotNull, ForeignKey("[spt].[Order]", "OrderId"), LeftJoin("jOrder")]
        public Int32? OrderId
        {
            get { return Fields.OrderId[this]; }
            set { Fields.OrderId[this] = value; }
        }

        [DisplayName("Product"), NotNull, ForeignKey("[spt].[Product]", "ProductId")]
        [LeftJoin("jProduct"), TextualField("ProductTitle")]

        //Lookup products
        [LookupEditor(typeof(ProductRow))]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Quantity"), NotNull]
        public Int32? Quantity
        {
            get { return Fields.Quantity[this]; }
            set { Fields.Quantity[this] = value; }
        }

        [DisplayName("Unit Price"), NotNull]
        public Double? UnitPrice
        {
            get { return Fields.UnitPrice[this]; }
            set { Fields.UnitPrice[this] = value; }
        }
        //total product price * quantity
        [DisplayName("Line Total")]
        [Expression("(t0.UnitPrice * t0.Quantity)")]

        public Double? LineTotal
        {
            get { return Fields.LineTotal[this]; }
            set { Fields.LineTotal[this] = value; }
        }

        // Product Name
        [DisplayName("Product Name")]
        [Expression("jProduct.[Title]")]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }


        [DisplayName("Order Cutormer Id"), Expression("jOrder.[CutormerId]")]
        public Int32? OrderCutormerId
        {
            get { return Fields.OrderCutormerId[this]; }
            set { Fields.OrderCutormerId[this] = value; }
        }

        [DisplayName("Order Status"), Expression("jOrder.[Status]")]
        public Int32? OrderStatus
        {
            get { return Fields.OrderStatus[this]; }
            set { Fields.OrderStatus[this] = value; }
        }

        [DisplayName("Order Release Date"), Expression("jOrder.[ReleaseDate]")]
        public DateTime? OrderReleaseDate
        {
            get { return Fields.OrderReleaseDate[this]; }
            set { Fields.OrderReleaseDate[this] = value; }
        }

        [DisplayName("Order Total"), Expression("jOrder.[Total]")]
        public Double? OrderTotal
        {
            get { return Fields.OrderTotal[this]; }
            set { Fields.OrderTotal[this] = value; }
        }

        [DisplayName("Product Title"), Expression("jProduct.[Title]")]
        public String ProductTitle
        {
            get { return Fields.ProductTitle[this]; }
            set { Fields.ProductTitle[this] = value; }
        }

        [DisplayName("Product Price"), Expression("jProduct.[Price]")]
        public Double? ProductPrice
        {
            get { return Fields.ProductPrice[this]; }
            set { Fields.ProductPrice[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.OrderDetailsId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OrderDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderDetailsId;
            public Int32Field OrderId;
            public Int32Field ProductId;
            public StringField ProductName;
            public Int32Field Quantity;
            public DoubleField UnitPrice;
            public DoubleField LineTotal;

            public Int32Field OrderCutormerId;
            public Int32Field OrderStatus;
            public DateTimeField OrderReleaseDate;
            public DoubleField OrderTotal;

            public StringField ProductTitle;
            public DoubleField ProductPrice;
        }
    }
}
