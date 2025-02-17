using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Table
{
    class stud_course
    {
        [Key]
        public int Stud_ID { get; set; }

        public int course_ID { get; set; }

        public int Grade { get; set; }


    }
}
