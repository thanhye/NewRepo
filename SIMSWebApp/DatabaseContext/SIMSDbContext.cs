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
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<ProgramCourse> ProgramCourses { get; set; }
        public DbSet<StudentProgram> StudentPrograms { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)        
        {
            // Định nghĩa entity làm bảng dữ liệu
            
            // User configuration
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey("UserID");
            modelBuilder.Entity<User>().HasIndex("UserName");
            modelBuilder.Entity<User>().Property(u => u.Role).HasDefaultValue("Admin");
            
            // Student configuration
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Student>().HasKey("StudentID");
            modelBuilder.Entity<Student>().HasIndex("Email");
            
            // Course configuration
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Course>().HasKey("CourseID");
            modelBuilder.Entity<Course>().HasIndex("CourseCode").IsUnique();
            
            // Department configuration
            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<Department>().HasKey("DepartmentID");
            modelBuilder.Entity<Department>().HasIndex("Name").IsUnique();
            
            // Faculty configuration
            modelBuilder.Entity<Faculty>().ToTable("Faculty");
            modelBuilder.Entity<Faculty>().HasKey("FacultyID");
            modelBuilder.Entity<Faculty>().HasIndex("Email");
            
            // Enrollment configuration
            modelBuilder.Entity<Enrollment>().ToTable("Enrollments");
            modelBuilder.Entity<Enrollment>().HasKey("EnrollmentID");
            modelBuilder.Entity<Enrollment>()
                .HasIndex("StudentID", "CourseID")
                .IsUnique();
            
            // CourseAssignment configuration
            modelBuilder.Entity<CourseAssignment>().ToTable("CourseAssignments");
            modelBuilder.Entity<CourseAssignment>().HasKey("CourseAssignmentID");
            modelBuilder.Entity<CourseAssignment>()
                .HasIndex("CourseID", "FacultyID")
                .IsUnique();
            
            // Program configuration
            modelBuilder.Entity<Program>().ToTable("Programs");
            modelBuilder.Entity<Program>().HasKey("ProgramID");
            modelBuilder.Entity<Program>().HasIndex("Name").IsUnique();
            
            // ProgramCourse configuration
            modelBuilder.Entity<ProgramCourse>().ToTable("ProgramCourses");
            modelBuilder.Entity<ProgramCourse>().HasKey("ProgramCourseID");
            modelBuilder.Entity<ProgramCourse>()
                .HasIndex("ProgramID", "CourseID")
                .IsUnique();
            
            // StudentProgram configuration
            modelBuilder.Entity<StudentProgram>().ToTable("StudentPrograms");
            modelBuilder.Entity<StudentProgram>().HasKey("StudentProgramID");
            modelBuilder.Entity<StudentProgram>()
                .HasIndex("StudentID", "ProgramID")
                .IsUnique();
            
            // Notification configuration
            modelBuilder.Entity<Notification>().ToTable("Notifications");
            modelBuilder.Entity<Notification>().HasKey("NotificationID");
            
            // Relationships
            modelBuilder.Entity<Student>()
                .HasOne(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserID)
                .OnDelete(DeleteBehavior.SetNull);
                
            modelBuilder.Entity<Faculty>()
                .HasOne(f => f.User)
                .WithMany()
                .HasForeignKey(f => f.UserID)
                .OnDelete(DeleteBehavior.SetNull);
                
            modelBuilder.Entity<Faculty>()
                .HasOne(f => f.Department)
                .WithMany(d => d.Faculty)
                .HasForeignKey(f => f.DepartmentID)
                .OnDelete(DeleteBehavior.SetNull);
                
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DepartmentID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
