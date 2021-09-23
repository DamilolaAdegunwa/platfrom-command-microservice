using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LocationService.Models
{
    public class Location : Entity
    {
        [Required]
        public string Address { get; set; }
        [Required]
        public string CountryName { get; set; }
        public int? CountryId { get; set; }
        [Required]
        public string StateName { get; set; }
        public int? StateId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
