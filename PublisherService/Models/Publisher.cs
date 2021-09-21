using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PublisherService.Models
{
    public class Publisher
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Founder { get; set; }
        [Required]
        public string YearFounded { get; set; }
        [Required]
        public string HeadquarterLocation { get; set; }
    }
}
