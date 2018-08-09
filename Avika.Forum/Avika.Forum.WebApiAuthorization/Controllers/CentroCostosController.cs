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
        public CentroCostosController()
        {
            this.context = new Context();
        }
        /// <summary>
        /// retorna todos los centros de costos
        /// </summary>
        /// <returns>Lista de centros de costos</returns>
        [Route(""), HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var items = this.context.CentroCostos.ToList();
            return Ok(new { items });
        }
    }
}
