using Entities = eMarket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eMarket.Host.Web.Models.Category
{
    public class CategoryListViewModel
    {
        public List<Entities.Category> Categories { get; set; }
    }
}