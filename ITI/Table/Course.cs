using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Table
{
    class Course
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        public int Name { get; set; }
        public int? Description { get; set; }        
        public int TOp_Id { get; set; }


        [InverseProperty("Course")]
        public ICollection<stud_course> Courses{ get; set; } = new HashSet<stud_course>();
    }
}
