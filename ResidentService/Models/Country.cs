using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ResidentService.Models
{
    public class Country: Entity
    {
        [Required]
        public string Name { get; set; }
        //[Required]
        public double LandAreaInSquareKilometer { get; set; }
    }
}
