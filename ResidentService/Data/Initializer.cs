using ResidentService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidentService.Data
{
    public class Initializer
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedDatabase(serviceScope.ServiceProvider.GetService<ResidentDbContext>());
            }
        }
        public static void SeedDatabase(ResidentDbContext context)
        {
            if(!context.Residents.Any())
            {
                context.Residents.AddRange(
                    new List<Resident>()
                    {
                        new Resident() { NameOfPerson = "Damilola Adegunwa", RentAmount = 750, NumberOfRooms = 3, Address = "25, Coker road, Ilupeju", CountryName = "Nigeria", StateName = "Lagos" },
                        new Resident() { NameOfPerson = "Olaniyi Idejo", RentAmount = 1750, NumberOfRooms = 2,Address = "3060 Kimball Bridge Rd. Suite 200", CountryName = "USA", StateName = "Georgia" },
                        new Resident() { NameOfPerson = "Adeola Ololade", RentAmount = 350, NumberOfRooms = 1,Address = "1 Facebook Way, Menlo Park, CA 94025", CountryName = "USA", StateName = "California" },
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
