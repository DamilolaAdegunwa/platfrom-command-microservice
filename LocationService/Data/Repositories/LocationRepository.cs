using LocationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationService.Data.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly IBaseRepository<Location> _baseRepository;

        public LocationRepository(IBaseRepository<Location> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public Task<Location> CreateLocation(Location input)
        {
            return _baseRepository.Add(input);
        }

        public Task<Location> GetLocation(int id)
        {
            return _baseRepository.Get(id);
        }

        public Task<IEnumerable<Location>> GetLocations()
        {
            return _baseRepository.GetAll();
        }
    }
}
