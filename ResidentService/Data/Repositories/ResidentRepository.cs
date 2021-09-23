using ResidentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidentService.Data.Repositories
{
    public class ResidentRepository : IResidentRepository
    {
        private readonly IBaseRepository<Resident> _baseRepository;

        public ResidentRepository(IBaseRepository<Resident> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public Task<Resident> CreateResident(Resident input)
        {
            return _baseRepository.Add(input);
        }

        public Task<Resident> GetResident(int id)
        {
            return _baseRepository.Get(id);
        }

        public Task<IEnumerable<Resident>> GetResidents()
        {
            return _baseRepository.GetAll();
        }
    }
}
