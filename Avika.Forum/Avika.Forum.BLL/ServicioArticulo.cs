using Avika.Forum.DAO;
using Avika.Forum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avika.Forum.LogDLL;
using System.Data;
using System.Data.Entity;
using AutoMapper;

namespace Avika.Forum.BLL
{
    public class ServicioArticulo : Repository<CoArticu>
    {
        Context contexto = null;
        public ServicioArticulo(Context context, Logger logger) : base(context, logger)
        {
            this.contexto = context;
        }

        public async Task<Pagination<ArticuloDTO>> Get(int ? pagina, int ? registros)
        {
            var totalRegistros = this.contexto.Articulos.Count();
            registros = registros == 0 ? totalRegistros : registros;
            var totalPaginas = (int)Math.Ceiling((double)totalRegistros / (int)registros);
            var items = this.contexto.Articulos.Include(a => a.CoCatPro).Include(a => a.CoTipMat)
                .OrderBy(c => c.Id)
                .Skip(((int)pagina - 1) * (int)registros)
                .Take((int)registros)
                .ToList();
            return new Pagination<ArticuloDTO>()
            {
                Items = Mapper.Map<ICollection<CoArticu>, ICollection<ArticuloDTO>>(items),
                TotalItems = totalRegistros,
                TotalPages = totalPaginas,
                CurrentPage= (int)pagina,
                ItemPerPage= (int)registros
            };
        }
        public ArticuloDTO GetId(int id)
        {
            return Mapper.Map<CoArticu, ArticuloDTO>(this.contexto.Articulos.Include(a=>a.CoCatPro).Include(a=>a.CoTipMat).FirstOrDefault(a=> a.Id == id));
        }
    }
}
