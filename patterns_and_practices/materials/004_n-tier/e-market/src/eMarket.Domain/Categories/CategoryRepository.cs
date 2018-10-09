using eMarket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Domain.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MarketDbContext context;

        public CategoryRepository(MarketDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Category> GetCategories()
        {
            return context.Categories
                .OrderBy(c => c.Name);
        }
    }
}
