using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublisherService.Data
{
    public class BaseRepository : IBaseRepository
    {
        private readonly PublisherDbContext _context;

        public BaseRepository(PublisherDbContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
