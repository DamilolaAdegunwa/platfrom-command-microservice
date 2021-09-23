using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LocationService.Models
{
    //or province
    public class State : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string CountryName { get; set; }
        public int? CountryId { get; set; }
    }
}
