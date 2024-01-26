using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240124190200)]
    public class DefaultDB_20240124_190200_TableOrderDetails : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("OrderDetails").InSchema("spt")
            .WithColumn("OrderDetailsId").AsInt32().Identity()
            .PrimaryKey().NotNullable()
            .WithColumn("OrderId").AsInt32().NotNullable()
            .ForeignKey("FK_OrderDetails_OrderId", "spt", "Order", "OrderId")
            .WithColumn("ProductId").AsInt32().NotNullable()
            .ForeignKey("FK_OrderDetails_CustomerId", "spt", "Product", "ProductId")
            .WithColumn("Quantity").AsInt32().NotNullable();
        }
    }
}