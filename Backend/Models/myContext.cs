using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options)
        : base(options)
        {
        }

        public DbSet<Skill> skills { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserSkills> UserSkills { get; set; }
    }
}
