
using Lab11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Lab11.Models
{
    public class SchoolContext  :   DbContext
    {
        public DbSet<Grade> Grades { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options)
         : base(options)
        {

        }



    }
}
