using System.Web.Http;
using WebActivatorEx;
using Avika.Forum.WebApi;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Avika.Forum.WebApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            GlobalConfiguration.Configuration
              .EnableSwagger(c => c.SingleApiVersion("v1", "Web Api AVIKA"))
              .EnableSwaggerUi();
        }
    }
}
