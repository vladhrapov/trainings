using Entities = eMarket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Domain.Product
{
    public interface IProductRepository
    {
        int Count { get; }
        List<Entities.Product> GetList();
    }
}
