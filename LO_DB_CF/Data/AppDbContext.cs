using LO_DB_CF.Entities;
using Microsoft.EntityFrameworkCore;

namespace LO_DB_CF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>()
                .HasOne(t => t.Batch)
                .WithMany()
                .HasForeignKey(t => t.BatchId)
                .OnDelete(DeleteBehavior.Restrict); // or .NoAction()

            modelBuilder.Entity<Topic>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict); // or .NoAction()

            modelBuilder.Entity<Topic>()
                .HasOne(t => t.Skill)
                .WithMany()
                .HasForeignKey(t => t.SkillId)
                .OnDelete(DeleteBehavior.Restrict); // or .NoAction()
        }
    }

}
