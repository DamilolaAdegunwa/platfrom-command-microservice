using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LocationService.Models
{
    public class Entity
    {
        public Entity()
        {
            LastModifiedDate = DateTimeOffset.Now;
            IsDeleted = false;
            CreationDate = DateTimeOffset. Now;
        }
        [Key]
        [Required]
        public int Id { get; set; }
        //[Required]
        public int? LastModifierId { get; set; }
        [Required]
        public DateTimeOffset LastModifiedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        //[Required]
        public int? DeleterId { get; set; }
        //[Required]
        public int? CreatorId { get; set; }
        [Required]
        public DateTimeOffset CreationDate { get; set; }
    }
}
