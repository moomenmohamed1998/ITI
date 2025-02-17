using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Table
{
    class Department
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public int Ins_ID { get; set; }

        public int HirindDate { get; set; }

        [InverseProperty("Departments")]

        public ICollection<Student> Students { get; set; }= new HashSet< Student >();




        //public Department()
        //{
        //    Students = new List<Student>();
        //}   


    }
}
