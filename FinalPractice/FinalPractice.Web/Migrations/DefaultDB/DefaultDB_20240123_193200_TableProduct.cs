using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240123193200)]
    public class DefaultDB_20240123_193200_TableProduct : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Schema("spt");
            Create.Table("Product").InSchema("spt")
            .WithColumn("ProductId").AsInt32().Identity().PrimaryKey().NotNullable()
            .WithColumn("Title").AsString(100).NotNullable()
            .WithColumn("Price").AsInt32().NotNullable();
        }
    }
}