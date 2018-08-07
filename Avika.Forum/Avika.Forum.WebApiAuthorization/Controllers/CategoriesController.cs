using Avika.Forum.BLL;
using Avika.Forum.DAO;
using Avika.Forum.Model;
using Avika.Forum.WebApiAuthorization.Infrastructure;
using Avika.Forum.WebApiAuthorization.Models;
using Avika.Forum.WebApiAuthorization.Properties;
using Microsoft.AspNet.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace Avika.Forum.WebApiAuthorization.Controllers
{
    [RoutePrefix("api/Categories")]
    public class CategoriesController : BaseApiController
    {
        readonly CategoryService _service = null;
        Context _avikaDB = null;
        string _element = "Categoria";
        public CategoriesController(): base()
        {
            _avikaDB = new Context();
            var repository = new CategoryRepository(_avikaDB, _logger);
            this._service = new CategoryService(repository);
        }
        /// <summary>
        /// Get {categorys}
        /// </summary>
        /// <returns>List of categorys </returns>
        [Route(""), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? page = null, [FromUri] int? qty = null)
        {
            page = page == null || page == 0 ? 1 : page;
            qty = qty ?? 0;
            return Ok(this._service.Get(page, qty).Result);
        }
        /// <summary>
        /// Get {category}
        /// </summary>
        /// <param name="id"></param>
        /// <returns>category </returns>
        [HttpGet]
        public async Task<IHttpActionResult> GetId(int id)
        {
            return Ok(_service.Get(id));
        }
        /// <summary>
        /// Post to category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [Route(""), CustomAuthorize(Role = "Administrador"), HttpPost]
        public async Task<IHttpActionResult> Post(Category category)
        {
            if (category == null)
                return BadRequest(String.Format(Resources.RequestEmpty, _element));
            var principal = RequestContext.Principal as ClaimsPrincipal;
            category.UserCreatorId = principal.Identity.GetUserId();
            category.UserModificatorId = principal.Identity.GetUserId();
            var res = this._service.Post(category).Result;
            if (res > 0)
                return Ok(String.Format(Resources.SaveOk, _element));
            else
                return BadRequest(String.Format(Resources.SaveError, _element));
        }
        /// <summary>
        /// Update {category}
        /// </summary>
        /// <retuns></returns>
        [Route(""), CustomAuthorize(Role = "Administrador"), HttpPut]
        public async Task<IHttpActionResult> Put(Category category)
        {
            if (category == null)
                return BadRequest(String.Format(Resources.RequestEmpty, _element));
            var principal = RequestContext.Principal as ClaimsPrincipal;
            category.UserModificatorId = principal.Identity.GetUserId();
            var res = this._service.Put(category).Result;
            switch (res)
            {
                case -1:
                    return BadRequest(String.Format(Resources.UpdateError, _element));
                default:
                    return Ok(String.Format(Resources.UpdateOk, _element));
            }

        }
        /// <summary>
        /// Delete {category}
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [Route("{id}"), CustomAuthorize(Role = "Administrador"), HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var res = this._service.Delete(id).Result;
            if (res > 0)
            {
                return Ok(String.Format(Resources.DeleteOk, _element));
            }
            else
            {
                return BadRequest(String.Format(Resources.DeleteError, _element));
            }
        }
    }
}
