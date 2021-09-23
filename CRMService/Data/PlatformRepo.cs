using CRMService.Dtos;
using CRMService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMService.Data
{
    public class CRMRepo : ICRMRepo
    {
        private readonly AppDbContext _context;
        public CRMRepo(AppDbContext context)
        {
            _context = context;
        }
        public CRM CreateCRM(CRM CRM)
        {
            if(CRM == null)
            {
                throw new ArgumentNullException(nameof(CRM), "you cannot null into the db!");
            }
            var p = _context.Add<CRM>(CRM);

            return p.Entity;
        }

        public CRM GetCRMById(int id)
        {
            return _context.CRMs.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<CRM> GetCRMs()
        {
            return _context.CRMs.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
