namespace MovieRentalShop.Handler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreFieldForMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Director", c => c.String());
            AddColumn("dbo.Movies", "Star", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Star");
            DropColumn("dbo.Movies", "Director");
        }
    }
}
