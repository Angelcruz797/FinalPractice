using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240125230200)]
    public class DefaultDB_20240125_230200_UpdateOrderDetails : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("OrderDetails").InSchema("spt")
            .AddColumn("UnitPrice").AsDouble().Nullable();
        }
    }
}