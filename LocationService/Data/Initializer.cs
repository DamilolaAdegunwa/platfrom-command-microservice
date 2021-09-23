using LocationService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationService.Data
{
    public class Initializer
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedDatabase(serviceScope.ServiceProvider.GetService<LocationDbContext>());
            }
        }
        public static void SeedDatabase(LocationDbContext context)
        {
            if(!context.Locations.Any())
            {
                context.Locations.AddRange(
                    new List<Location>()
                    {
                        new Location() { Address = "25, Coker road, Ilupeju", CountryName = "Nigeria", StateName = "Lagos" },
                        new Location() { Address = "3060 Kimball Bridge Rd. Suite 200", CountryName = "USA", StateName = "Georgia" },
                        new Location() { Address = "1 Facebook Way, Menlo Park, CA 94025", CountryName = "USA", StateName = "California" },
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
