using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StudentModels
    {
        private StudentsDBContext context = null;

        public StudentModels()
        {
            context = new StudentsDBContext();
        }

        public List<DB_Students> ListAll()
        {
            var list = context.Database.SqlQuery<DB_Students>("Students_ListAll").ToList();
            return list;
        }

        public int Create(string stcode, string stname,
                            string stclass, int stindentitycard,
                            double? stpoin, string stcomment,
                            bool? ststatus, string stadderess,
                            string stborn, DateTime? stbirthday,
                            string stparents, string stimage)
        {
            object[] para = 
            {
                new SqlParameter("@StudentCode", stcode),
                new SqlParameter("@StudentName", stname),
                new SqlParameter("@StudentClass", stclass),
                new SqlParameter("@StudentPoint", stpoin),
                new SqlParameter("@StudentComment", stcomment ?? (object)DBNull.Value), // input value null
                new SqlParameter("@StudentStatus", ststatus ),
                new SqlParameter("@StudentAddress", stadderess ?? (object)DBNull.Value),
                new SqlParameter("@StudentBorn", stborn ?? (object)DBNull.Value),
                new SqlParameter("@StudentIdentityCard", stindentitycard),
                new SqlParameter("@StudentBirthDay", stbirthday),
                new SqlParameter("@StudentParents", stparents ?? (object)DBNull.Value),
                new SqlParameter("@StudentImage", stimage ?? (object)DBNull.Value)
            };

            

            int res = context.Database.ExecuteSqlCommand
                ("Student_Insert @StudentCode, @StudentName, @StudentClass, @StudentPoint, @StudentComment, @StudentStatus, @StudentAddress, @StudentBorn, @StudentIdentityCard, @StudentBirthDay, @StudentParents, @StudentImage", para);
            return res;
        }
    }
}
