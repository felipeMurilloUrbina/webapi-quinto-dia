using Avika.Forum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avika.Forum.LogDLL;

namespace Avika.Forum.DAO
{
    public class CompanyRepository : Repository<Company>
    {
        public CompanyRepository(Context context, Logger logger) : base(context, logger)
        {
        }
    }
}
