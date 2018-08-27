using AutoMapper;
using Avika.Forum.DAO;
using Avika.Forum.LogDLL;
using Avika.Forum.Model;
using Avika.Forum.Model.Dto;
using System;
using System.Collections.Generic;

namespace Avika.Forum.BLL
{
     public class ServicioSalida: Repository<CoMovInv>
    {
        Context contexto = null;
        public ServicioSalida(Context context, Logger logger) : base(context, logger)
        {
            this.contexto = context;
        }

        public string GuardarSalida(List<SalidaAlmacenDTO> salidas)
        {

            var lista = Mapper.Map<List<SalidaAlmacenDTO > , List<CoMovInv>>(salidas);
            this.contexto.MovimientosInventario.AddRange(lista);
            try
            {
                this.contexto.SaveChanges();
            }
            catch (Exception e )
            {
                _logger.EscribirError(e.InnerException.ToString());
                return e.ToString();
            }
            return "";
        }
    }
}
