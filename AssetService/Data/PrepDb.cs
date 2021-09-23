using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetService.Models;
namespace AssetService.Data
{
    public static class PrepDb
    {
        public static void PrePopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        public static void SeedData(AppDbContext context)
        {
            if(!context.Assets.Any())
            {
                Console.WriteLine("Seeding data");
                context.AddRange(
                new List<Asset>(){
                    new Asset(){Name = "Dot Net", Publisher = "Microsoft", Cost = "Free"},
                    new Asset(){Name = "Entity Framework", Publisher = "Microsoft", Cost = "Free"},
                    new Asset(){Name = "Kubernetes", Publisher = "Cloud Native cloud Foundation", Cost = "Free"},
                    new Asset(){Name = "GCP", Publisher = "Google", Cost = "Free"},
                    new Asset(){Name = "F8", Publisher = "Facebook", Cost = "Free"},
                    new Asset(){Name = "Oracle cloud", Publisher = "Oracle", Cost = "Free"},
                }
                );
            }
            else
            {
                Console.WriteLine($"There is already data in the table");
            }
            context.SaveChanges();
        }
    }
}
