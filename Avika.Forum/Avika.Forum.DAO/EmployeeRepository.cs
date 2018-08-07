using Avika.Forum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avika.Forum.LogDLL;

namespace Avika.Forum.DAO
{
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository(Context context, Logger logger) : base(context, logger)
        {
        }
    }
}
