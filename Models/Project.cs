using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ojotobar.Models
{
    public class Project
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
