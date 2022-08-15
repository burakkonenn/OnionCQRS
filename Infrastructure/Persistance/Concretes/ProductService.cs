using Application.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
        => new()
        {

            new(){Id = Guid.NewGuid(), Name = "Telefon", Price = 1000, Stock = 10, CreatedDate = DateTime.Now},
            new(){Id = Guid.NewGuid(), Name = "Nokia", Price = 2000, Stock = 20, CreatedDate = DateTime.Now},
            new(){Id = Guid.NewGuid(), Name = "Samsung", Price = 3000, Stock = 30, CreatedDate = DateTime.Now},
            new(){Id = Guid.NewGuid(), Name = "İphone", Price = 4000, Stock = 40, CreatedDate = DateTime.Now}
        };
    }
}
