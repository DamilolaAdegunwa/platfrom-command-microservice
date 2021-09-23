using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidentService.Data.Repositories
{
    public interface IBaseRepository<T>
    {
        bool SaveChanges();
        Task<T> Add(T input);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
