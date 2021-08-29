using Microsoft.Owin;
using NS804Test.DataAccess;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(NS804Test.Api.Startup))]

namespace NS804Test.Api
{
    public partial class Startup
    {
        /// <summary>
        /// Configure the DbContext to be used as an unique instance per request
        /// </summary>
        /// <param name="app"></param>
        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);
        }
    }
}
