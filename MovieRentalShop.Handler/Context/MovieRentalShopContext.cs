using MovieRentalShop.Handler.Entities;
using System.Data.Common;
using System.Data.Entity;

namespace MovieRentalShop.Handler.Context
{
    public class MovieRentalShopContext : DbContext
    {
        public MovieRentalShopContext() : base("name=MovieRentalShopConnectionString")
        {
            // https://blog.oneunicorn.com/2013/05/28/database-initializer-and-migrations-seed-methods/
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieRentalShopContext
            //    , MovieRentalShop.Handler.Migrations.Configuration>("MovieRentalShopConnectionString"));
        }

        public MovieRentalShopContext(DbConnection connection)
            : base(connection, true)
        {
            // Connection is disposed when the context is disposed
        }

        
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
