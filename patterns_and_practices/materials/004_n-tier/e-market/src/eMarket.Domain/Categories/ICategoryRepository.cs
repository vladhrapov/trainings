using eMarket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Domain.Categories
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories();
    }
}
