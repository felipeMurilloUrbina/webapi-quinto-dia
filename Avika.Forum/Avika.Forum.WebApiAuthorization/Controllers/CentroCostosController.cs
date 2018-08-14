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
    [RoutePrefix("api/centro-costos")]
    public class CentroCostosController : BaseApiController
    {
        private SevicioCentroCosto servicio;

        public CentroCostosController()
        {
            this.servicio = new SevicioCentroCosto(new Context(), this._logger);
        }
        /// <summary>
        /// retorna todos los centros de costos
        /// </summary>
        /// <returns>Lista de centros de costos</returns>
        [Route(""), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? pagina = null, [FromUri] int? registros = null)
        {
            return Ok(await this.servicio.Get(pagina, registros));
        }
    }
}
