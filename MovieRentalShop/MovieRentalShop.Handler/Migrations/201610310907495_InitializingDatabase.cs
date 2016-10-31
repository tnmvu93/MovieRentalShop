namespace MovieRentalShop.Handler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializingDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Password = c.String(),
                        Gender = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
