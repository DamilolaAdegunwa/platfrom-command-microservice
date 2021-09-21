using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublisherService.Models;
namespace PublisherService.Data
{
    public static class DbInitialization
    {
        public static void Initializer(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedDatabase(serviceScope.ServiceProvider.GetService<PublisherDbContext>());
            }
           
        }
        public static void SeedDatabase(PublisherDbContext context)
        {
            if(!context.Publishers.Any())
            {
                Console.WriteLine("--> seeding database");
                context.Publishers.AddRange(
                    new List<Publisher>() { 
                        new Publisher(){ Name = "Microsoft", Founder = "Bill Gates", HeadquarterLocation = "USA", YearFounded = "1975"},
                        new Publisher(){ Name = "Facebook", Founder = "Mark Zuckerberg", HeadquarterLocation = "USA", YearFounded = "2004"},
                        new Publisher(){ Name = "Twitter", Founder = "Jack", HeadquarterLocation = "USA", YearFounded = "2006"},
                        new Publisher(){ Name = "Google", Founder = "Larry Page", HeadquarterLocation = "USA", YearFounded = "1998"},
                    }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("There is already data");
            }
        }
    }
}
