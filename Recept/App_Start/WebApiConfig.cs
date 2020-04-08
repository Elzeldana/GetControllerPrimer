using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using log4net;
using Biblioteka.Repo;
using Biblioteka.Services;
using System.Reflection;
namespace Recept
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<DatabaseRepo>().As<IDataRepo>();
            builder.RegisterType<ProductService>().As<IProductService>();
                       
            builder.Register(c => LogManager.GetLogger(typeof(object))).As<ILog>();


            var container = builder.Build();


            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
