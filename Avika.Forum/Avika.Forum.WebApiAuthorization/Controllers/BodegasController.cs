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
    [RoutePrefix("api/bodegas")]
    public class BodegasController : BaseApiController
    {
        private ServicioBodega servicio;
        public BodegasController()
        {
        }

        /// <summary>
        /// Obtener Bodegas
        /// </summary>
        /// <returns>Lista de bodegas</returns>
        [Route(""), HttpGet, CustomAuthorize]
        public async Task<IHttpActionResult> Get([FromUri]int? pagina = null, [FromUri] int? registros = null)
        {

            this.servicio = new ServicioBodega(new Context(CustomAuthorizeAttribute.CadenaConexion), this._logger);
            var items = this.servicio.Get();
            return Ok(new {items});
        }
        /// <summary>
        /// Obtener bodega
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Bodega</returns>
        [Route("{id}"), HttpGet, CustomAuthorize]
        public async Task<IHttpActionResult> Get([FromUri]int? id = null)
        {
            this.servicio = new ServicioBodega(new Context(CustomAuthorizeAttribute.CadenaConexion), this._logger);
            return Ok();
        }

    }
}
