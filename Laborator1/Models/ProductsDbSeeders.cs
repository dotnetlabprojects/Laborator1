using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator1.Models
{
    public class ProductsDbSeeders
    {

        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();
             
            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "shirt",
                    Description = "kids",
                    Category = "clothes",
                    Price = 40
                },
                new Product
                {
                    Name = "hat",
                    Description = "women",
                    Category = "accessories",
                    Price = 100
                }
            );
            context.SaveChanges();
        }
    }
}
