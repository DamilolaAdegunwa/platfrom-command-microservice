using AssetService.Dtos;
using AssetService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetService.Data
{
    public class AssetRepo : IAssetRepo
    {
        private readonly AppDbContext _context;
        public AssetRepo(AppDbContext context)
        {
            _context = context;
        }
        public Asset CreateAsset(Asset Asset)
        {
            if(Asset == null)
            {
                throw new ArgumentNullException(nameof(Asset), "you cannot null into the db!");
            }
            var p = _context.Add<Asset>(Asset);

            return p.Entity;
        }

        public Asset GetAssetById(int id)
        {
            return _context.Assets.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Asset> GetAssets()
        {
            return _context.Assets.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
