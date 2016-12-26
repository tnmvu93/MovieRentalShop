namespace MovieRentalShop.Handler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDummyDataForMovie : DbMigration
    {
        public override void Up()
        {
            Sql(Configuration.RenderSqlScript("sqlDummyMovieData.sql"));
        }
        
        public override void Down()
        {
        }
    }
}
