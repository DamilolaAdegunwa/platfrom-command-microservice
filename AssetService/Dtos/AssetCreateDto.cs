using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetService.Dtos
{
    public class AssetCreateDto
    {
        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Cost { get; set; }
    }
}
