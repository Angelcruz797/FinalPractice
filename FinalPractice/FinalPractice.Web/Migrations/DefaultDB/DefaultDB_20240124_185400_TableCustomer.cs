using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240124185400)]
    public class DefaultDB_20240124_185400_TableCustomer : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Customer").InSchema("spt")
            .WithColumn("CustomerId").AsInt32().Identity().PrimaryKey().NotNullable()
            .WithColumn("Firstname").AsString(50).NotNullable()
            .WithColumn("Lastname").AsString(50).NotNullable()
            .WithColumn("Gender").AsInt32().NotNullable()
            .WithColumn("Email").AsString().Nullable();
        }
    }
}