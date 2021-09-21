using PublisherService.Dtos;
using PublisherService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublisherService.Data
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly IBaseRepository _baseRepository;
        private readonly PublisherDbContext _context;

        public PublisherRepository(IBaseRepository baseRepository, PublisherDbContext context)
        {
            _baseRepository = baseRepository;
            _context = context;
        }

        public async Task<Publisher> CreatePublisher(Publisher publisher)
        {
            if(publisher == null)
            {
                throw new ArgumentNullException(nameof(CreatePublisher), "publisher cannot be null");
            }
            else
            {
                var response = _context.Add<Publisher>(publisher);
                _baseRepository.SaveChanges();
                return response.Entity;
            }
        }

        public async Task<Publisher> GetPublisher(int id)
        {
            return _context.Publishers.FirstOrDefault(a => a.Id == id);
        }

        public async Task<IEnumerable<Publisher>> GetPublishers()
        {
            return _context.Publishers.ToList();
        }
    }
}
