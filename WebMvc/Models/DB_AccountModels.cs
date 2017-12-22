using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

namespace Models
{
    public class DB_AccountModels
    {
        private StudentsDBContext context = null;

        public DB_AccountModels()
        {
            context = new StudentsDBContext();
        }

        public bool Login(string username, string password)
        {
            object[] sqlparams =
            {
                new SqlParameter("@SM_UserName", username),
                new SqlParameter("@SM_Password", password)
            };

            var res = context.Database.SqlQuery<bool>("Student_Management_Account @SM_UserName, @SM_Password", sqlparams).SingleOrDefault();

            return res;
        }
    }
}
