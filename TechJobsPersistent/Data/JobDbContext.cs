using TechJobsPersistent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TechJobsPersistent.Data
{
    //public class JobDbContext : DbContext
    public class JobDbContext: IdentityDbContext<IdentityUser>
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<JobSkill> JobSkills { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public JobDbContext(DbContextOptions<JobDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobSkill>()
                .HasKey(j => new { j.JobId, j.SkillId });
            base.OnModelCreating(modelBuilder);
        }

        //  dotnet ef migrations add InitialMigration
        //  dotnet ef database update
    }
}
