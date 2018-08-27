using Avika.Forum.BLL;
using Avika.Forum.DAO;
using Avika.Forum.Model.Dto;
using Avika.Forum.WebApiAuthorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Avika.Forum.WebApiAuthorization.Controllers
{
    [CustomAuthorize(Role ="Administrador"), RoutePrefix("api/salidas-almacen")]
    public class SalidasAlmacenController : BaseApiController
    {
        private ServicioSalida servicio;
        public SalidasAlmacenController()
        {
        }

        [Route(""), HttpPost]
        public IHttpActionResult Post(ICollection<SalidaAlmacenDTO> salidas)
        {
            if ((salidas == null) || salidas.Count == 0)
                return BadRequest("La lista de salidas viene vacia.");
            this.servicio = new ServicioSalida(new Context(CustomAuthorizeAttribute.CadenaConexion), this._logger);
            return Ok(servicio.GuardarSalida((List<SalidaAlmacenDTO>)salidas));
        }
    }
}
