using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240126221100)]
    public class DefaultDB_20240126_221100_UpdateOrder2 : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Order").InSchema("spt")
            .AddColumn("ShipCity").AsInt32().Nullable();
        }
    }
}