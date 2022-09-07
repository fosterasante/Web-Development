using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ClassLibrary.Models
{
    public class Student : User
    {
        [Display(Name = "Class")]
        public ClassOfStudents ClassOfStudents { get; set; }
    }
}
