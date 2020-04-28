using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace PizzaShop.Models
{
    public class PizzaShopDbContext : DbContext
    {
        public PizzaShopDbContext(DbContextOptions<PizzaShopDbContext> options) : base(options)
        { }
        public DbSet<Product> Products {get; set;}
        public DbSet<Order> Orders { get; set; }

    }
}
