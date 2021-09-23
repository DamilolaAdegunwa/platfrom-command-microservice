using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationService.Dtos
{
    public class LocationReadDto
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
    }
}
