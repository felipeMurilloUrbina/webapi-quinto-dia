using Avika.Forum.LogDLL;
using Avika.Forum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.DAO
{
    public class DepartmentRepository : Repository<Department>
    {
        public DepartmentRepository(Context context, Logger logger) : base(context, logger)
        {
        }
    }
}
