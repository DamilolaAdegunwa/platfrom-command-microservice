using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidentService.Dtos
{
    public class ResidentCreateDto
    {
        public string NameOfPerson { get; set; }

        public string Address { get; set; }
        
        public decimal RentAmount { get; set; }

        public int NumberOfRooms { get; set; }

        
        public string StateName { get; set; }
        public string CountryName { get; set; }
    }
}
