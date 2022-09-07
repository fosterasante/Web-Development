using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ClassLibrary.Models
{
     public enum ClassOfStudents
    {
        [Display(Name = "Class 1")]
        class1,
        [Display(Name = "Class 2")]
        class2,
        [Display(Name = "Class 3")]
        class3,
        [Display(Name = "Class 4")]
        class4,
        [Display(Name = "Class 5")]
        class5,
        [Display(Name = "Class 6")]
        class6,
    }
}
