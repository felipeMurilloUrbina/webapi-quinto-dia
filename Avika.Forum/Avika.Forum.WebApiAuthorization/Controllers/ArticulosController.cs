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
        public ArticulosController()
        {
            this.context = new Context();
        }

        /// <summary>
        /// Get {articulos}
        /// </summary>
        /// <returns>List of articulos</returns>
        [Route(""), HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var items = this.context.Articulos.ToList();
            return Ok(new { items });
        }


    }
}
