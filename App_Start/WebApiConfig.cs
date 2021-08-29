using FluentValidation.WebApi;
using NS804Test.Api.JwtGenerator;
using NS804Test.Service.Validations.ActionFiltersValidator;
using Swashbuckle.Application;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NS804Test.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var enableCorsAttribute = new EnableCorsAttribute("*", "Origin, Content-Type, Accept", "GET, POST, PUT");
            config.EnableCors(enableCorsAttribute);

            config.MapHttpAttributeRoutes();

            config.Filters.Add(new ValidateModelStateFilter());
            FluentValidationModelValidatorProvider.Configure(config);

            config.MessageHandlers.Add(new TokenValidationHandler());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Set Swagger as default start page

            config.Routes.MapHttpRoute(
                name: "swagger_root",
                routeTemplate: "",
                defaults: null,
                constraints: null,
                handler: new RedirectHandler((message => message.RequestUri.ToString()), "swagger"));

        }
    }
}
