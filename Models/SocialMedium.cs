﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ojotobar.Models
{
    public class SocialMedium
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string ProfileLink { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
