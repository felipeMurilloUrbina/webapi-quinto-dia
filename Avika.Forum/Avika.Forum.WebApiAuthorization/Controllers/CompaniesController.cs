using Avika.Forum.BLL;
using Avika.Forum.DAO;
using Avika.Forum.Model;
using Avika.Forum.WebApiAuthorization.Infrastructure;
using Avika.Forum.WebApiAuthorization.Properties;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace Avika.Forum.WebApiAuthorization.Controllers
{
    [RoutePrefix("api/companies")]
    public class CompaniesController : BaseApiController
    {
        readonly CompanyService _service = null;
        Context _avikaDB = null;
        string _element = "Sucursal";
        public CompaniesController(): base()
        {
            _avikaDB = new Context();
            var repository = new CompanyRepository(_avikaDB, _logger);
            this._service = new CompanyService(repository);
        }
        /// <summary>
        /// Get {companys}
        /// </summary>
        /// <returns>List of companys </returns>
        [Route(""), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? page = null, [FromUri] int? qty = null)
        {
            page = page == null || page == 0 ? 1 : page;
            qty = qty ?? 0;
            return Ok(this._service.Get(page, qty).Result);
        }
        /// <summary>
        /// Get {company}
        /// </summary>
        /// <param name="id"></param>
        /// <returns>company </returns>
        [Route("{id}"),HttpGet]
        public async Task<IHttpActionResult> GetId(int id)
        {
            var res = await _service.Get(id);
            return Ok(res);
        }
        /// <summary>
        /// Post to company
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [Route(""), CustomAuthorize(Role = "Administrador"), HttpPost]
        public async Task<IHttpActionResult> Post(Company company)
        {
            if (company == null)
                return BadRequest(String.Format(Resources.RequestEmpty, _element));
            var principal = RequestContext.Principal as ClaimsPrincipal;
            company.UserCreatorId = principal.Identity.GetUserId();
            company.UserModificatorId = principal.Identity.GetUserId();
            var res = this._service.Post(company);
            if (String.IsNullOrEmpty(res))
                return Ok(String.Format(Resources.SaveOk, _element));
            else
                return BadRequest(String.Format(res));
        }
        /// <summary>
        /// Update {company}
        /// </summary>
        /// <retuns></returns>
        [Route(""), CustomAuthorize(Role = "Administrador"), HttpPut]
        public async Task<IHttpActionResult> Put(Company company)
        {
            if (company == null)
                return BadRequest(String.Format(Resources.RequestEmpty, _element));
            var principal = RequestContext.Principal as ClaimsPrincipal;
            company.UserCreatorId = principal.Identity.GetUserId();
            company.UserModificatorId = principal.Identity.GetUserId();
            var res = this._service.Put(company).Result;
            if (String.IsNullOrEmpty(res))
                return Ok(String.Format(Resources.SaveOk, _element));
            else
                return BadRequest(String.Format(res));

        }
        /// <summary>
        /// Delete {company}
        /// </summary>
        /// <param name="company"></param>
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
