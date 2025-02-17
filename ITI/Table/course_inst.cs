using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Table
{
    class course_inst
    {
        [Key]
        public int inst_ID { get; set; }
        public int course_ID { get; set; }
        public string evaluate { get; set; }
    }
}
