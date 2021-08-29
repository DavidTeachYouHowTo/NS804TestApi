using AutoMapper;
using NS804Test.Services.Profiles;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace NS804Test.Api
{
    public class WebApiApplication : HttpApplication
    {
        internal static MapperConfiguration MapperConfiguration { get; set; }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            MapperConfiguration = MapperProfile.MapperConfiguration();
        }
    }
}
