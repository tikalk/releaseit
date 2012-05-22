using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ReleaseIt.Composition;
using ReleaseIt.Repository.Contracts;
using ReleaseIt.Web.MVC.Bundling;

namespace ReleaseIt.Web.Client
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //web API
            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //default ASP.NET MVC rounting
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            InitMef();
            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            Database.DefaultConnectionFactory = new SqlConnectionFactory("Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            
            //debug rounts
            //RouteDebug.RouteDebugger.RewriteRoutesForTesting(RouteTable.Routes);

            BundleTable.Bundles.EnableDefaultBundles();
            CustomJsBundle.Init();
        }

        private void InitMef()
        {
            //TODO change the path to more secure way
            var catalog = new AggregateCatalog(new DirectoryCatalog(Server.MapPath(".") + @"\bin"), new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            MefContainer.Container = new CompositionContainer(catalog);

            //get the object context
            var rep = MefContainer.Container.GetExportedValue<IReleaseItContext>();
         
        }        
    }
}