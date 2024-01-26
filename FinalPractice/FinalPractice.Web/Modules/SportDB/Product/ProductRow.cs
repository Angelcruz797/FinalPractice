
namespace FinalPractice.SportDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("SportDB"), TableName("[spt].[Product]")]
    [DisplayName("Product"), InstanceName("Product")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("SportDB.Product")]
    public sealed class ProductRow : Row, IIdRow, INameRow
    {
        [DisplayName("Product Id"), Identity]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Title"), Size(100), NotNull, QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Price (RD$)"), NotNull, LookupInclude]
        public Double? Price
        {
            get { return Fields.Price[this]; }
            set { Fields.Price[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProductId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProductId;
            public StringField Title;
            public DoubleField Price;
        }
    }
}
