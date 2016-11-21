namespace MovieRentalShop.Handler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMovieDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Imdb = c.Single(nullable: false),
                        Description = c.String(),
                        Year = c.Int(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
