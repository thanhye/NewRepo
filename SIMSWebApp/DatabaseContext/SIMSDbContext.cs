using Microsoft.EntityFrameworkCore;
using SIMSWebApp.DatabaseContext.Entities;

namespace SIMSWebApp.DatabaseContext
{
    public class SIMSDbContext : DbContext
    {
        public SIMSDbContext(DbContextOptions<SIMSDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // định nghiz entity làm bảng dữ liệu 
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey("UserID");
            modelBuilder.Entity<User>().HasIndex("UserName");
            modelBuilder.Entity<User>().Property(u => u.Role).HasDefaultValue("Admin");


        }
    }
}
