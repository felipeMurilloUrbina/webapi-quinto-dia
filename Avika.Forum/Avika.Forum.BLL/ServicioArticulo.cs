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

        public async Task<Pagination<ArticuloDTO>> Get(string bodegaId, int ? pagina, int ? registros)
        {
            var totalRegistros = this.contexto.Articulos.Count();
            registros = registros == 0 ? totalRegistros : registros;
            var totalPaginas = (int)Math.Ceiling((double)totalRegistros / (int)registros);
            var items = this.contexto.Articulos.Include(a => a.CoCatPro).Include(a => a.CoTipMat).Include(a=>a.CoArtBods).Where(a => a.CoArtBods.FirstOrDefault(aE => aE.BodegaArb.Equals(bodegaId)).CanExiArb > 0)
                .OrderBy(c => c.Id)
                .Skip(((int)pagina - 1) * (int)registros)
                .Take((int)registros)
                .ToList();
            CoArtBod _bodega = null;
            foreach(var item in items)
            {
                _bodega = item.CoArtBods.FirstOrDefault(aE => aE.BodegaArb.Equals(bodegaId));
                item.Existencia = _bodega.CanExiArb == null ? 0 : (decimal)_bodega.CanExiArb;
                item.CostoPromedio = (decimal)_bodega.CtoPromArb;
            }
            return new Pagination<ArticuloDTO>()
            {
                Items = Mapper.Map<ICollection<CoArticu>, ICollection<ArticuloDTO>>(items),
                TotalItems = totalRegistros,
                TotalPages = totalPaginas,
                CurrentPage= (int)pagina,
                ItemPerPage= (int)registros
            };
        }
        public int GetCantidad()
        {
            return this.contexto.Articulos.Count();
        }
        public ArticuloDTO GetId(int id)
        {
            return Mapper.Map<CoArticu, ArticuloDTO>(this.contexto.Articulos.Include(a=>a.CoCatPro).Include(a=>a.CoTipMat).FirstOrDefault(a=> a.Id == id));
        }
    }
}
