using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240126191100)]
    public class DefaultDB_20240126_191100_UpdateCustomer : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Customer").InSchema("spt")
            .AddColumn("UserId").AsInt32().Nullable()
            .ForeignKey("FK_Customer_UserId","dbo", "Users", "UserId");
        }
    }
}