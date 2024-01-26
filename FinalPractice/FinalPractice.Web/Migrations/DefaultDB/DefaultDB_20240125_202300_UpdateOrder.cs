using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240125202300)]
    public class DefaultDB_20240125_202300_UpdateOrder : Migration
    {
        public override void Up()
        {
            Delete.Column("Total").FromTable("Order").InSchema("spt");
        }
        public override void Down()
        {
        }
    }
}