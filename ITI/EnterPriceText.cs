using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Table;
using Microsoft.EntityFrameworkCore;

namespace ITI
{
    class EnterPriceText : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>();

            modelBuilder.Entity<Course>().HasKey(s => s.Id);

            modelBuilder.Entity<Topic>().HasKey(s => s.ID);

            modelBuilder.Entity<Department>();

            modelBuilder.Entity<instructor>().HasKey(s => s.ID);


            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EnterPriceDB;Integrated Security=True;");
        }

        public DbSet<Student> Students{ get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<stud_course> stud_course { get; set; }
        public DbSet<Topic> Topic { get; set; }

        public DbSet<course_inst> course_inst { get; set; }

        public DbSet<instructor> instructor { get; set; }





    }
}
