using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20260601_0346)]
public class DefaultDB_20260601_0346_MovieKind : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Movie")
            .AddColumn("Kind").AsInt32().NotNullable().WithDefaultValue(1);
    }
}