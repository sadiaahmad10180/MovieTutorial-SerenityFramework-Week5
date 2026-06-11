using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20260601_0400)]
public class DefaultDB_20260601_0400_GenreTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Genre")
            .WithColumn("GenreId").AsInt32().NotNullable()
                .PrimaryKey().Identity()
            .WithColumn("Name").AsString(100).NotNullable();

        Alter.Table("Movie")
            .AddColumn("GenreId").AsInt32().Nullable()
                .ForeignKey("FK_Movie_GenreId", "Genre", "GenreId");

        Insert.IntoTable("Genre")
            .Row(new { Name = "Action" })
            .Row(new { Name = "Drama" })
            .Row(new { Name = "Comedy" })
            .Row(new { Name = "Sci-fi" })
            .Row(new { Name = "Fantasy" })
            .Row(new { Name = "Documentary" });
    }
}