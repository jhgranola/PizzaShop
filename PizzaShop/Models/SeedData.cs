using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace PizzaShop.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PizzaShopDbContext context = app.ApplicationServices.GetRequiredService<PizzaShopDbContext>();

            context.Database.Migrate();

            //PizzaShopDbContext context = services.GetRequiredService<PizzaShopDbContext>();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Pepperoni Pizza", Price = 12.99M },
                    new Product { Name = "Mushroom Pizza", Price = 10.99M },
                    new Product { Name = "Sausage Pizza", Price = 13.99M }
                    );
            context.SaveChanges();
            }
        }
    }
}
