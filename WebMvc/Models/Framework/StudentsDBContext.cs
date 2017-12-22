using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Framework
{
    public partial class StudentsDBContext : DbContext
    {
        public StudentsDBContext()
            : base("Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True")
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<DB_Accounts> Accounts { get; set; }

        public virtual DbSet<DB_Students> Students { get; set; }

        public virtual DbSet<DB_Class> Class { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Accounts
            modelBuilder.Entity<DB_Accounts>().Property(e => e.A_UserName).IsUnicode(false);

            modelBuilder.Entity<DB_Accounts>().Property(e => e.A_Password).IsUnicode(false);

            //Class
            modelBuilder.Entity<DB_Class>().Property(e => e.Class_ID).IsUnicode(false);

            modelBuilder.Entity<DB_Class>().Property(e => e.Class_NumberOfStudents);

            modelBuilder.Entity<DB_Class>().Property(e => e.Class_Teacher).IsUnicode(false);

            modelBuilder.Entity<DB_Class>().Property(e => e.Class_Status);

            modelBuilder.Entity<DB_Class>().Property(e => e.Class_Comment).IsUnicode(false);

            //Students
            modelBuilder.Entity<DB_Students>().Property(e => e.Student_ID);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Code).IsUnicode(false);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Name).IsUnicode(false);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Class).IsUnicode(false);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Point);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Comment).IsUnicode(false);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Status);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Address).IsUnicode(false);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Born).IsUnicode(false);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_BirthDay);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_IdentityCard);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Image).IsUnicode(false);

            modelBuilder.Entity<DB_Students>().Property(e => e.Student_Parents).IsUnicode(false);
        }
    }
}
