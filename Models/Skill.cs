using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ojotobar.Models
{
    public class Skill
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int Level { get; set; }
        public string SkillIconUrl { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
