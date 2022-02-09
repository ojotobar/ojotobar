using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ojotobar.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string ImageUrl { get; set; }
        public string AboutId { get; set; }
        public About About { get; set; }
        public List<Certification> Certification { get; set; }
        public List<Project> Project { get; set; }
        public List<Skill> Skill { get; set; }
        public List<SocialMedium> SocialMedium { get; set; }

    }
}
