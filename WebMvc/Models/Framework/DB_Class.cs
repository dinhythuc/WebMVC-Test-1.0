using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Framework
{
    [Table("Class")]
    public partial class DB_Class
    {
        [Key]
        [StringLength(10)]
        [Display(Name="ID")]
        public string Class_ID { get; set; }

        [Display(Name = "Number of students")]
        public int Class_NumberOfStudents { get; set; }

        [StringLength(50)]
        [Display(Name = "Teacher")]
        public string Class_Teacher { get; set; }

        [Display(Name = "Status")]
        public bool Class_Status { get; set; }

        [StringLength(500)]
        [Display(Name = "Comment")]
        public string Class_Comment { get; set; }

        public virtual ICollection<DB_Students> Student_ID_Class { get; set; }
    }
}
