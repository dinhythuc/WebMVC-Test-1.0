using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Framework
{
    //[Table("Students")]
    public partial class DB_Students
    {
        [Key]
        [Column(Order = 1)]
        [Display(Name = "ID")]
        public int Student_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [Display(Name = "IdentityCard")]
        public int Student_IdentityCard { get; set; }

        [StringLength(30, ErrorMessage = "Student code cannot be longer than 30 characters")]
        [Display(Name = "Student code")]
        public string Student_Code { get; set; }

        [StringLength(50, ErrorMessage = "Student name cannot be longer than 50 characters")]
        [Display(Name = "Name")]
        public string Student_Name { get; set; }


        //[ForeignKey("DB_Class")]
        [StringLength(10, ErrorMessage = "Class cannot be longer than 10 characters")]
        [Display(Name = "Class")]
        public string Student_Class { get; set; }

        [Display(Name = "Point")]
        public double? Student_Point { get; set; }

        [StringLength(500, ErrorMessage = "Comment cannot be longer than 500 characters")]
        [Display(Name = "Comment")]
        public string Student_Comment { get; set; }

        [Display(Name = "Status")]
        public bool? Student_Status { get; set; }

        [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters")]
        [Display(Name = "Address")]
        public string Student_Address { get; set; }

        [StringLength(50, ErrorMessage = "Born cannot be longer than 50 characters")]
        [Display(Name = "Born")]
        public string Student_Born { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        [Display(Name = "Birth day")]
        public DateTime Student_BirthDay { get; set; }

        [StringLength(50, ErrorMessage = "Name parents cannot be longer than 50 characters")]
        [Display(Name = "Parents")]
        public string Student_Parents { get; set; }

        [StringLength(50, ErrorMessage = "Image cannot be longer than 250 characters")]
        [Display(Name = "Image")]
        public string Student_Image { get; set; }
    }
}
