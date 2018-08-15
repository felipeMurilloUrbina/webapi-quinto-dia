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
    [RoutePrefix("api/bodegas")]
    public class BodegasController : BaseApiController
    {
        private ServicioBodega servicio;
        public BodegasController()
        {
            this.servicio = new ServicioBodega(new Context(), this._logger);
        }

        /// <summary>
        /// Obtener Bodegas
        /// </summary>
        /// <returns>Lista de bodegas</returns>
        [Route(""), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? pagina = null, [FromUri] int? registros = null)
        {

            var items = this.servicio.Get();
            return Ok(new {items});
        }
        /// <summary>
        /// Obtener bodega
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Bodega</returns>
        [Route("{id}"), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? id = null)
        {
            //var articulo = this.servicio.GetId((int)id);
            //return Ok(articulo);
            return Ok();
        }

    }
}
