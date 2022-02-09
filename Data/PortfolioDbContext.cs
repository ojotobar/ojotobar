using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ojotobar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ojotobar.Data
{
    public class PortfolioDbContext : IdentityDbContext<AppUser>
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {

        }

        public DbSet<About> About { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Certification> Certification { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<SocialMedium> SocialMedium { get; set; }
    }
}
