namespace MovieRentalShop.Handler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldToSaveImageOfMovieDirectlyInDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Image", c => c.Binary());
            DropColumn("dbo.Movies", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "ImageUrl", c => c.String());
            DropColumn("dbo.Movies", "Image");
        }
    }
}
