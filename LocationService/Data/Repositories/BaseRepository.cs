using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationService.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T: class
    {
        private readonly LocationDbContext _context;

        public BaseRepository(LocationDbContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public async Task<T> Add(T input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "input can not be null!");
            }
            var resp = _context.Add<T>(input);
            SaveChanges();
            return resp.Entity;
        }

        public async Task<T> Get(int id)
        {
            return _ = _context.Find<T>(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return _ = _context.Set<T>().ToList();
        }
    }
}
