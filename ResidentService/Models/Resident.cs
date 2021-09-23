using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ResidentService.Models
{
    public class Resident : Entity
    {
        
        
        [Required]
        public string NameOfPerson { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public decimal RentAmount { get; set; }
        [Required]
        public int NumberOfRooms { get; set; }
        
        [Required]
        public string StateName { get; set; }
        [Required]
        public string CountryName { get; set; }

    }
}
