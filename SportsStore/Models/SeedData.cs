using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace SportsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A single-person boat",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "A single-person boat",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A single-person boat",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A single-person boat",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A single-person boat",
                        Category = "Watersports",
                        Price = 275
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
