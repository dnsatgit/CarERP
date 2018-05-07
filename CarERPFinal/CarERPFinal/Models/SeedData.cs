using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CarERPFinal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarERPFinalContext(
                serviceProvider.GetRequiredService<DbContextOptions<CarERPFinalContext>>()))
            {
                // Look for any movies.
                if (context.Services.Any())
                {
                    return;   // DB has been seeded
                }

                context.Services.AddRange(
                     new Services
                     {
                         ServiceName = "AC",
                         ListedDate = DateTime.Parse("2014-9-11"),
                         ServiceType = "Repair Service: Labor",
                         Price = 100,
                         CustomerRating="4"
                     },
                     
                     new Services
                     {
                         ServiceName = "Brakes",
                         ListedDate = DateTime.Parse("1999-1-11"),
                         ServiceType = "Repair Service: Labor",
                         Price = 80,
                         CustomerRating = "3"
                     }, 
                     
                     new Services
                     {
                         ServiceName = "Gas Engine Diagnostics",
                         ListedDate = DateTime.Parse("2001-9-11"),
                         ServiceType = "Repair Service: Labor",
                         Price = 50,
                         CustomerRating = "5"
                     },
                     new Services
                     {
                         ServiceName = "Plastic/Fiberglass Repair",
                         ListedDate = DateTime.Parse("2012-4-8"),
                         ServiceType = "Repair Service: Labor",
                         Price = 300,
                         CustomerRating = "3"
                     }

                );
                context.SaveChanges();
            }
        }
    }
}