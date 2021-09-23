using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationService.Dtos
{
    public class LocationCreateDto
    {
        public string Address { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
    }
}
