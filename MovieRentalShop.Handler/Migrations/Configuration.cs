using MovieRentalShop.Handler.Context;
using System;
using System.Data.Entity.Migrations;
using System.IO;

namespace MovieRentalShop.Handler.Migrations
{
     internal sealed class Configuration : DbMigrationsConfiguration<MovieRentalShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieRentalShopContext context)
        {
            
        }
        
        public static string RenderSqlScript(string sqlFile)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Migrations", sqlFile);
            return File.OpenText(path).ReadToEnd();
        }      
    }
}
