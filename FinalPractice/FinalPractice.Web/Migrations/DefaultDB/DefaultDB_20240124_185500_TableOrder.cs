using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240124185500)]
    public class DefaultDB_20240124_185500_TableOrder : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Order").InSchema("spt")
            .WithColumn("OrderId").AsInt32().Identity().PrimaryKey().NotNullable()
            .WithColumn("CutormerId").AsInt32().NotNullable()
            .ForeignKey("FK_Order_CustomerId", "spt", "customer", "CustomerId")
            .WithColumn("Status").AsInt32().NotNullable().WithDefaultValue(1)
            .WithColumn("ReleaseDate").AsDateTime().Nullable()
            .WithColumn("Total").AsDouble().NotNullable();

        }
    }
}