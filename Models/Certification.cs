using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ojotobar.Models
{
    public class Certification
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Link { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
