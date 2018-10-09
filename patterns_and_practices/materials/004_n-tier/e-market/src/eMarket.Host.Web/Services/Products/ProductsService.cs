using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities = eMarket.Core.Entities;
using eMarket.Domain.Product;
using eMarket.Host.Web.Models.Product;

namespace eMarket.Host.Web.Services.Product
{
    public class ProductsService : IProductsService
    {
        private readonly IProductRepository productRepository;

        public ProductsService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ProductListViewModel GetList()
        {
            var products = productRepository.GetList();

            var model = new ProductListViewModel
            {
                Products = products,
                Count = products.Count,
                Page = 1
            };

            return model;
        }

        public ProductListViewModel GetListByCategory(string name)
        {
            // ToDo: Move this logic to repository
            var products = productRepository.GetList()
                .Where(p => p.Category.Name.ToLowerInvariant() == name)
                .ToList();

            var model = new ProductListViewModel
            {
                Products = products,
                Count = products.Count,
                Page = 1
            };

            return model;
        }

        public Entities.Product GetProductById(int id)
        {
            // ToDo: Move this logic to repository
            var model = productRepository.GetList()
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return model;
        }
    }
}