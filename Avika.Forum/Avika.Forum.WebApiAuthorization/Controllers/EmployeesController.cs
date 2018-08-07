using Avika.Forum.BLL;
using Avika.Forum.DAO;
using Avika.Forum.Model;
using Avika.Forum.WebApiAuthorization.Infrastructure;
using Avika.Forum.WebApiAuthorization.Models;
using Avika.Forum.WebApiAuthorization.Properties;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
    [RoutePrefix("api/employees")]
    public class EmployeesController : BaseApiController
    {
        readonly EmployeeService _service = null;
        Context _avikaDB = null;
        string _element = "Empleado";
        public EmployeesController() : base()
        {
            _avikaDB = new Context();
            var repository = new EmployeeRepository(_avikaDB, _logger);
            this._service = new EmployeeService(repository);
        }
        /// <summary>
        /// Get {Categories}
        /// </summary>
        /// <returns>List of Categories </returns>
        [Route(""), HttpGet]
        public async Task<IHttpActionResult> Get([FromUri]int? page = null, [FromUri] int? qty = null)
        {
            page = page == null || page == 0 ? 1 : page;
            qty = qty ?? 0;
            return Ok(this._service.Get(page, qty).Result);
        }
        /// <summary>
        /// Get {employee}
        /// </summary>
        /// <param name="id"></param>
        /// <returns>employee </returns>
        [HttpGet]
        public async Task<IHttpActionResult> GetId(int id)
        {
            return Ok(_service.Get(id));
        }
        /// <summary>
        /// Post to employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [Route(""), CustomAuthorize(Role = "Administrador"), HttpPost]
        public async Task<IHttpActionResult> Post(Employee employee)
        {
            if (employee == null)
                return BadRequest(String.Format(Resources.RequestEmpty, _element));
            var principal = RequestContext.Principal as ClaimsPrincipal;
            employee.UserCreatorId = principal.Identity.GetUserId();
            employee.UserModificatorId = principal.Identity.GetUserId();
            var res = this._service.Post(employee);
            System.Web.Security.Membership.GeneratePassword(10, 5);
            if (string.IsNullOrEmpty(res))
            {
                User user = new User()
                {
                    Email = employee.Email,
                    EmailConfirmed = false,
                    Active= false,
                    UserName = employee.Email,
                    Name= employee.Name,
                    LastName  = employee.LastName,
                    Avatar= "default.png",
                };
                IdentityResult addUserResult = await this.AppUserManager.CreateAsync(user, System.Web.Security.Membership.GeneratePassword(10, 5));
                return Ok(String.Format(Resources.SaveOk, _element));
            }
            else
                return BadRequest(res);
        }
        /// <summary>
        /// Update {employee}
        /// </summary>
        /// <retuns></returns>
        [Route(""), CustomAuthorize(Role = "Administrador"), HttpPut]
        public async Task<IHttpActionResult> Put(Employee employee)
        {
            if (employee == null)
                return BadRequest(String.Format(Resources.RequestEmpty, _element));
            var principal = RequestContext.Principal as ClaimsPrincipal;
            employee.UserModificatorId = principal.Identity.GetUserId();
            var res = this._service.Put(employee).Result;
            switch (res)
            {
                case -1:
                    return BadRequest(String.Format(Resources.UpdateError, _element));
                default:
                    return Ok(String.Format(Resources.UpdateOk, _element));
            }

        }
        /// <summary>
        /// Delete {employee}
        /// </summary>
        /// <param name="employee"></param>
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
