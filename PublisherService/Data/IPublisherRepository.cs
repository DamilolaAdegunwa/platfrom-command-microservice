using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublisherService.Dtos;
using PublisherService.Models;
namespace PublisherService.Data
{
    public interface IPublisherRepository
    {
        Task<IEnumerable<Publisher>> GetPublishers();
        Task<Publisher> GetPublisher(int id);
        Task<Publisher> CreatePublisher(Publisher publisher);
    }
}
