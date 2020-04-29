using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "Pepperoni Pizza", Price = 12.99M},
            new Product {Name = "Mushroom Pizza", Price = 10.99M},
            new Product {Name = "Sausage Pizza", Price = 13.99M},
        }.AsQueryable<Product>();
    }
}
