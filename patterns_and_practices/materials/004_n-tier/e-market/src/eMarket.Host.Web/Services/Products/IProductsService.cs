using Entities = eMarket.Core.Entities;
using eMarket.Host.Web.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMarket.Host.Web.Services.Product
{
    public interface IProductsService
    {
        ProductListViewModel GetList();
        ProductListViewModel GetListByCategory(string name);
        Entities.Product GetProductById(int id);
    }
}