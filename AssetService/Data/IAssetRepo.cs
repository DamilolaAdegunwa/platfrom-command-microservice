using AssetService.Dtos;
using AssetService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetService.Data
{
    public interface IAssetRepo
    {
        bool SaveChanges();
        IEnumerable<Asset> GetAssets();
        Asset GetAssetById(int id);
        Asset CreateAsset(Asset Asset);
    }
}
