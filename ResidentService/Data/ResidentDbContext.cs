using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResidentService.Models;
namespace ResidentService.Data
{
    public class ResidentDbContext: DbContext
    {
        public ResidentDbContext(DbContextOptions<ResidentDbContext> options) : base(options)
        {

        }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
    }
}
