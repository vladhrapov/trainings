namespace eMarket.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eMarket.Domain.MarketDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(eMarket.Domain.MarketDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //var category = context.Categories.Add(new Core.Entities.Category
            //{
            //    Name = "Cars",
            //});

            //context.Products.AddOrUpdate(new Core.Entities.Product {
            //    Name = "VW",
            //    Description = "This is the best car",
            //    Price = 235664,
            //    Quantity = 2,
            //    CategoryId = category.Id
            //});
        }
    }
}
