using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Avika.Forum.WebApiAuthorization.Infrastructure
{
    public class CustomAuthorizeAttribute: AuthorizationFilterAttribute
    {
        public static string CadenaConexion = "";
        public string Role { get; set; }
        public override Task OnAuthorizationAsync(HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken)
        {
            CustomAuthorizeAttribute.CadenaConexion = actionContext.Request.Headers.GetValues("granja").FirstOrDefault();
            if(String.IsNullOrEmpty(CustomAuthorizeAttribute.CadenaConexion))
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                return Task.FromResult<object>(null);
            }
            var principal = actionContext.RequestContext.Principal as ClaimsPrincipal;

            if (!principal.Identity.IsAuthenticated)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                return Task.FromResult<object>(null);
            }

            //User is Authorized, complete execution
            return Task.FromResult<object>(null);

        }
    }
}