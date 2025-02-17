using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Table
{
    class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public int Lname { get; set; }
        public string? Adress { get; set; }
        public int? Age { get; set; }

        //public long Dep_Id { get; set; }


        [ForeignKey("Dep_Id")]
        [InverseProperty("Students")]
        public Department Departments { get; set; }

        [InverseProperty("Students")]
        public ICollection<stud_course> Students { get; set; } = new HashSet<stud_course>();
    }
}
