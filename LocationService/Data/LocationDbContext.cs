using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocationService.Models;
namespace LocationService.Data
{
    public class LocationDbContext: DbContext
    {
        public LocationDbContext(DbContextOptions<LocationDbContext> options) : base(options)
        {

        }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
    }
}
