
namespace FinalPractice.SportDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("SportDB"), TableName("[spt].[Customer]")]
    [DisplayName("Customer"), InstanceName("Customer")]

    //only read permission
    [ReadPermission(PermissionKeys.Customer.View)]

    [ModifyPermission("Administration:General")]

    //LookUp
    [LookupScript("SportDB.Customer")]
    public sealed class CustomerRow : Row, IIdRow, INameRow
    {
        [DisplayName("Customer Id"), Identity]
        public Int32? CustomerId
        {
            get { return Fields.CustomerId[this]; }
            set { Fields.CustomerId[this] = value; }
        }

        [DisplayName("Firstname"), Size(50), NotNull]
        public String Firstname
        {
            get { return Fields.Firstname[this]; }
            set { Fields.Firstname[this] = value; }
        }

        [DisplayName("Lastname"), Size(50), NotNull]
        public String Lastname
        {
            get { return Fields.Lastname[this]; }
            set { Fields.Lastname[this] = value; }
        }

        //Concat the firstname and lastname

        [DisplayName("Full Name")]
        [Expression("(t0.Firstname + ' ' + t0.Lastname)"), QuickSearch]
        public String Fullname
        {
            get { return Fields.Fullname[this]; }
            set { Fields.Fullname[this] = value; }
        }
        // user email
        [DisplayName("Email")]
        [Expression("jUser.[Email]")]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        // customer gender (male or female) 
        [DisplayName("Gender"), NotNull]
        public Gender? Gender
        {
            get { return (Gender?)Fields.Gender[this]; }
            set { Fields.Gender[this] = (Int32?)value; }
        }
        // Address
        [DisplayName("Address"),Width(200),DefaultValue("none")]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        //concat Fullname and Username
        [Expression("(t0.Firstname + ' ' + t0.Lastname +' ' + '('+ jUser.[Username] +')')")]
        public String FullUsername
        {
            get { return Fields.FullUsername[this]; }
            set { Fields.FullUsername[this] = value; }
        }
        // id user
        [DisplayName("User"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUser"), TextualField("")]
        [Expression("t0.[CustomerId]")]

        public Int32? UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.CustomerId; }
        }

        StringField INameRow.NameField
        {
            //show in Lookup the "fullname (username)"
            get { return Fields.FullUsername; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomerRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CustomerId;
            public Int32Field UserId;
            public StringField Firstname;
            public StringField Lastname;

            public StringField Fullname;
            public StringField FullUsername;
            public StringField Address;
            public Int32Field Gender;
            public StringField Email;
        }
    }
}
