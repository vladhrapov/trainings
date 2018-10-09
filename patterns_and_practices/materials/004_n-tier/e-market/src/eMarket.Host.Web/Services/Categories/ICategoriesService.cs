using eMarket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMarket.Host.Web.Services.Categories
{
    public interface ICategoriesService
    {
        List<Category> GetCategories();
    }
}