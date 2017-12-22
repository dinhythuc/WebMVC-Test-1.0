using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Framework
{
    [Table("DB_Account")]
    public partial class DB_Accounts
    {
        [Key]
        [StringLength(50)]
        [Display(Name = "User name")]
        public string A_UserName { get; set; }

        [StringLength(50)]
        public string A_Password { get; set; }
    }
}
