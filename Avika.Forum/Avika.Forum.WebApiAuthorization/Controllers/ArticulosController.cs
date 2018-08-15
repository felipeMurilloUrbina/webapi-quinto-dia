using Avika.Forum.BLL;
using Avika.Forum.DAO;
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
            this.servicio = new ServicioArticulo(new Context(), this._logger);
        }

        /// <summary>
        /// Get {articulos}
        /// </summary>
        /// <returns>List of articulos</returns>
        [Route(""), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? pagina = null, [FromUri] int? registros = null)
        {
            var bodega = Request.Headers.GetValues("bodega").FirstOrDefault();
            if (bodega == null)
                return BadRequest("Es necesario seleccionar una bodega.");
            return Ok(await this.servicio.Get(bodega, pagina, registros));
        }
        [Route("{id}"), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? id = null)
        {
            var articulo = this.servicio.GetId((int)id);
            return Ok(articulo);
        }

        [Route("cantidad"), HttpGet]
        public async Task<IHttpActionResult> GetCantidad()
        {
            var cantidad = this.servicio.GetCantidad();
            return Ok(cantidad);
        }

    }
}
