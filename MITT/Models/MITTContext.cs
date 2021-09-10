using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace MITT.Models
{
    public class MITTContext : Microsoft.EntityFrameworkCore.DbContext
    {
        //public MITTContext(string connectionString) : base(GetOptions(connectionString))
        //{

        //}

        //private static DbContextOptions GetOptions(string connectionString)
        //{
        //    return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        //}
        public MITTContext(DbContextOptions<MITTContext> options)
        : base(options)
        {
        }
        public System.Data.Entity.DbSet<Skill> skills { get; set; }
        public System.Data.Entity.DbSet<SkillLevel> SkillLevels { get; set; }
        public System.Data.Entity.DbSet<User> Users { get; set; }
        public System.Data.Entity.DbSet<UserProfile> UserProfiles { get; set; }
        public System.Data.Entity.DbSet<UserSkills> UserSkills { get; set; }
    }
}
