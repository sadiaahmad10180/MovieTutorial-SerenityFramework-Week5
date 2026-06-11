using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20260601_1605)]
public class DefaultDB_20260601_1605_PersonMovieImages : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Person")
            .AddColumn("PrimaryImage").AsString(100).Nullable()
            .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();

        Alter.Table("Movie")
            .AddColumn("PrimaryImage").AsString(100).Nullable()
            .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();
    }
}