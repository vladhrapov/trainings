using eMarket.Domain.Product;
using eMarket.Host.Web.Models.Product;
using eMarket.Host.Web.Services.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eMarket.Host.Web.Controllers
{
    [RoutePrefix("Products")]
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        // GET: Product
        [Route("")]
        public ActionResult List()
        {
            var model = productsService.GetList();

            return View(model);
        }

        [Route("{productId:int}")]
        public ActionResult Product(int productId)
        {
            var model = productsService.GetProductById(productId);

            return View(model);
        }

        [Route("~/Categories/{categoryName}/Products", Name = "ProductsByCategory")]
        public ActionResult ListByCategory(string categoryName)
        {
            var model = productsService.GetListByCategory(categoryName);

            return View("List", model);
        }
    }
}