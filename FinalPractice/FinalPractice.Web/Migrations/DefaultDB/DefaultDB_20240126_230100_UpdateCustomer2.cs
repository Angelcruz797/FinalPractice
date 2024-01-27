using FluentMigrator;

namespace FinalPractice.Migrations.DefaultDB
{
    [Migration(20240126230100)]
    public class DefaultDB_20240126_230100_UpdateCustomer2 : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Customer").InSchema("spt")
            .AddColumn("Address").AsString(255).NotNullable()
            .WithDefaultValue("");
        }
    }
}