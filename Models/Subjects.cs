using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ClassLibrary.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        [Required]
        [Range(0, 30)]
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }
        public int ICT { get; set; }
        public int RME { get; set; }
        public int BDT { get; set; }
        public int French { get; set; }
        public int Twi { get; set; }
    }
}
