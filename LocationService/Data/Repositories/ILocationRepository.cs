using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocationService.Data;
using LocationService.Models;
namespace LocationService.Data.Repositories
{
    public interface ILocationRepository
    {
        Task<Location> CreateLocation(Location input);
        Task<IEnumerable<Location>> GetLocations();
        Task<Location> GetLocation(int id);
    }
}
