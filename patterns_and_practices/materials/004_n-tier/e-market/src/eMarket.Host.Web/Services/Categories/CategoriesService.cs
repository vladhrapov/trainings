using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eMarket.Core.Entities;
using eMarket.Domain.Categories;

namespace eMarket.Host.Web.Services.Categories
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public List<Category> GetCategories()
        {
            return categoryRepository.GetCategories().ToList();
        }
    }
}