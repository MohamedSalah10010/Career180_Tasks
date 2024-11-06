using Microsoft.EntityFrameworkCore;

namespace CRUD_CodeFirstCoursesDataBase_WEBAPI_day3.Models
{
    public class courseContext : DbContext
    {
        public virtual DbSet<courses> courses { get; set; }

        public courseContext(DbContextOptions<courseContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<courses>().HasData(
                new courses { ID = 1, Crs_name = "Introduction to Programming", crs_desc = "Basic programming concepts", Duration = 30 },
                new courses { ID = 2, Crs_name = "Data Structures", crs_desc = "Learn various data structures", Duration = 40 },
                new courses { ID = 3, Crs_name = "Web Development", crs_desc = "Building web applications", Duration = 45 },
                new courses { ID = 4, Crs_name = "Database Management", crs_desc = "Fundamentals of database systems", Duration = 35 },
                new courses { ID = 5, Crs_name = "Machine Learning", crs_desc = "Introduction to machine learning concepts", Duration = 50 },
                new courses { ID = 6, Crs_name = "Embedded Systems", crs_desc = "Basics of embedded system design", Duration = 25 },
                new courses { ID = 7, Crs_name = "Cloud Computing", crs_desc = "Introduction to cloud services", Duration = 40 },
                new courses { ID = 8, Crs_name = "Cybersecurity Basics", crs_desc = "Foundations of cybersecurity", Duration = 30 },
                new courses { ID = 9, Crs_name = "Artificial Intelligence", crs_desc = "AI concepts and applications", Duration = 55 },
                new courses { ID = 10, Crs_name = "Networking Essentials", crs_desc = "Fundamentals of networking", Duration = 20 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
