using System;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;
using epms.WebAPI.Infrastructure;
using Microsoft.Owin;
using Newtonsoft.Json.Serialization;
using Ninject.Web.Common.OwinHost;
using Owin;
using WebApiContrib.IoC.Ninject;

[assembly: OwinStartup(typeof(epms.WebAPI.Startup))]

namespace epms.WebAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            ConfigureWebApi(config);
            config.DependencyResolver = new NinjectResolver(NinjectWebCommon.CreateKernel());
            app.UseWebApi(config);
        }

        private void ConfigureWebApi(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            var jsonFormatter = new JsonMediaTypeFormatter();
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiation(jsonFormatter));
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
