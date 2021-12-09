namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (5, 'Superheroes')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (6, 'Sci-fi')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (7, 'History')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (8, 'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
