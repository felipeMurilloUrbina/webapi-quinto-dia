using Avika.Forum.DAO;
using Avika.Forum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avika.Forum.LogDLL;

namespace Avika.Forum.BLL
{
    public class SevicioCentroCosto : Repository<CoCentroCosto>
    {
        public SevicioCentroCosto(Context context, Logger logger) : base(context, logger)
        {
        }
        public async Task<Pagination<CoCentroCosto>> Get(int? pagina, int? registros)
        {
            return await base.Get(pagina, registros);
        }
    }
}
