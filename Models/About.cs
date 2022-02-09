using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ojotobar.Models
{
    public class About
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string AboutDescription { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
