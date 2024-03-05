using Microsoft.EntityFrameworkCore;

namespace demo.Models
{
    // ApplicationDpContext inherits from DbContext
    public class ApplicationDpContext : DbContext
    {
        //constructor (علشان نباصي قيم من الكلاس بتاعنا لل دي بي كونتيكست)
        public ApplicationDpContext(DbContextOptions options) : base(options)
        {

        }

        //Create DataBase for students, Departments, Registrations,  Courses
        public DbSet<student> students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Course> Courses { get; set; }

        //migration
    }
}
