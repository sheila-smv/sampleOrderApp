namespace Cleverbit.Data.Migrations
{
    using Cleverbit.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cleverbit.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationDbContext>()); //TODO: for this case, will recreate everytime
        }

        protected override void Seed(Cleverbit.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(x => x.Id,
                new Product { Id = new Guid("2e2c9748-0521-430d-b2a9-effd09d358a2"), Name = "Product 1", Description = "Product 1", Price = 1, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = new Guid("2923d40d-75d7-4566-a1e5-6d3a000ece4b"), Name = "Product 2", Description = "Product 2", Price = 2.5m, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = new Guid("56d6c5f3-e492-4243-b8f1-d47592127630"), Name = "Product 3", Description = "Product 3", Price = 14, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = new Guid("ea58a3df-c321-4462-9c50-16c6544f4661"), Name = "Product 4", Description = "Product 4", Price = 35, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
              );

        }
    }
}
