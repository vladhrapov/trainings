using eMarket.Host.Web.Models.Category;
using eMarket.Host.Web.Services.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eMarket.Host.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        // GET: Categories
        public ActionResult List()
        {
            var categories = categoriesService.GetCategories();

            var model = new CategoryListViewModel
            {
                Categories = categories
            };

            return PartialView(model);
        }
    }
}