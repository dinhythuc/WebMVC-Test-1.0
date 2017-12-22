using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMvc.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Display(Name="Name")]
        [Required]
        public string StudentName { get; set; }

        [Range(5,50)]
        public int Age { get; set; }

        public bool IsNewlyEnrolled { get; set; }

        public string Password { get; set; }

        public Standard standard { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}