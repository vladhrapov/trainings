using Entities = eMarket.Core.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace eMarket.Domain
{
    public class MarketDbContext : IdentityDbContext<Entities.User>
    {
        public MarketDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
        
        public DbSet<Entities.Product> Products { get; set; }
        public DbSet<Entities.Category> Categories { get; set; }
        public DbSet<Entities.News> News { get; set; }
    }
}
