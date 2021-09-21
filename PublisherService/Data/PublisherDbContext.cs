using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PublisherService.Models;

namespace PublisherService.Data
{
    public class PublisherDbContext: DbContext
    {
        public PublisherDbContext(DbContextOptions<PublisherDbContext> options) : base(options)
        {

        }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
