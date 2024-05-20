using Microsoft.EntityFrameworkCore;

namespace UniversumSchoolManagement.Data
{
    public partial class UniversumDbContext : DbContext
    {
        public UniversumDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Enrollment> Enrollments { get; set; }

        public virtual DbSet<Lecturer> Lecturers { get; set; }

        public virtual DbSet<Student> Students { get; set; }
    }
}
