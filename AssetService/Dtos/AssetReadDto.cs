using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetService.Dtos
{
    public class AssetReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Cost { get; set; }
    }
}
