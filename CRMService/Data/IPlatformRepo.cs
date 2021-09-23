using CRMService.Dtos;
using CRMService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMService.Data
{
    public interface ICRMRepo
    {
        bool SaveChanges();
        IEnumerable<CRM> GetCRMs();
        CRM GetCRMById(int id);
        CRM CreateCRM(CRM CRM);
    }
}
