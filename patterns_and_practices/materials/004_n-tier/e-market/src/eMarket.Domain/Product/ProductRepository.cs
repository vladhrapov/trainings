using Entities = eMarket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace eMarket.Domain.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly MarketDbContext context;
        public int Count => context.Products.Count();

        public ProductRepository(MarketDbContext context)
        {
            this.context = context;
        }

        public List<Entities.Product> GetList()
        {
            return context.Products.ToList();
        }
    }
}
