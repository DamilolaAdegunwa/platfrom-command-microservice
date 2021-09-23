using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResidentService.Data;
using ResidentService.Models;
namespace ResidentService.Data.Repositories
{
    public interface IResidentRepository
    {
        Task<Resident> CreateResident(Resident input);
        Task<IEnumerable<Resident>> GetResidents();
        Task<Resident> GetResident(int id);
    }
}
