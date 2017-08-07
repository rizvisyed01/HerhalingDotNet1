using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Herhaling1.Models
{
    public class Student
    {
        [Required]
        [Display(Name ="Student id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

    }
}
