using Models.Framework;
using System;
using System.Collections.Generic;
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
    }
}
