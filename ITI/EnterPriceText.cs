using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Table;
using Microsoft.EntityFrameworkCore;

namespace ITI
{
    class EnterPriceText:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            
            optionsBuilder.UseSqlServer("Server=.;Database=EnterPriceDB;Integrated Security=True;");


        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<stud_course> stud_course { get; set; }
        public DbSet<Topic> Topic { get; set; }

        public DbSet<course_inst> course_inst { get; set; }

        public DbSet<instructor> instructor { get; set; }


     


    }
}
