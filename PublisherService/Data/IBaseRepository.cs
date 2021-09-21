using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublisherService.Data
{
    public interface IBaseRepository
    {
        bool SaveChanges();
    }
}
