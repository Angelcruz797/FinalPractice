using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240125174900)]
    public class DefaultDB_20240125_174900_UpdateProduct : Migration
    {
        public override void Up()
        {
            Delete.Column("Price").FromTable("Product").InSchema("spt");

            Alter.Table("Product").InSchema("spt")
            .AddColumn("Price").AsDouble().Nullable();
        }
        public override void Down()
        {
        }
    }
}