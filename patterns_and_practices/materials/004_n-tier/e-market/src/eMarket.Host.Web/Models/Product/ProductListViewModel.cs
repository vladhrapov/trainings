using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMarket.Host.Web.Models.Product
{
    public class ProductListViewModel
    {
        public List<Core.Entities.Product> Products { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
    }
}   