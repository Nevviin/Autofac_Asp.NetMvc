using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using MVC_RepositoryAutoFac.Repositories;

namespace MVC_RepositoryAutoFac
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AreaRegistration.RegisterAllAreas();
            // Setup the Container Builder
            var builder = new ContainerBuilder();
            // Register the controller in scope 
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            // Register types
            builder.RegisterType<SqlServerRepository>().As<IRepository>();
            
            //builder.RegisterType(typeof(SqlServerRepository)).AsImplementedInterfaces();
            // buld the container
            var container = builder.Build();
            
            //Resolve the dependency using the dependency resolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}