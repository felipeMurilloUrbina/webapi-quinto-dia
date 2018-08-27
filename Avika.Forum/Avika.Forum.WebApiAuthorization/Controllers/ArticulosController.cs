using Avika.Forum.BLL;
using Avika.Forum.DAO;
using Avika.Forum.WebApiAuthorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Avika.Forum.WebApiAuthorization.Controllers
{
    [RoutePrefix("api/articulos")]
    public class ArticulosController : BaseApiController
    {
        private ServicioArticulo servicio;
        public ArticulosController()
        {
        }

        /// <summary>
        /// Get {articulos}
        /// </summary>
        /// <returns>List of articulos</returns>
        [CustomAuthorize(Role = "Administrador"), Route(""), HttpGet ]
        public async Task<IHttpActionResult> Get([FromUri]int? pagina = null, [FromUri] int? registros = null)
        {
            this.servicio = new ServicioArticulo(new Context(CustomAuthorizeAttribute.CadenaConexion), this._logger);
            var bodega = Request.Headers.GetValues("bodega").FirstOrDefault();
            return Ok(await this.servicio.Get(bodega, pagina, registros));
        }
        [CustomAuthorize(Role = "Administrador"), Route("{id}"), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? id = null)
        {
            this.servicio = new ServicioArticulo(new Context(CustomAuthorizeAttribute.CadenaConexion), this._logger);
            var articulo = this.servicio.GetId((int)id);
            return Ok(articulo);
        }

        [CustomAuthorize(Role = "Administrador"), Route("cantidad"), HttpGet]
        public async Task<IHttpActionResult> GetCantidad()
        {
            this.servicio = new ServicioArticulo(new Context(CustomAuthorizeAttribute.CadenaConexion), this._logger);
            var cantidad = this.servicio.GetCantidad();
            return Ok(cantidad);
        }

    }
}
