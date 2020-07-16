using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using StudentMgmtServices.Interfaces;
using StudentMgmtServices.Services;
using System.Web.Http;
using System.Web.Mvc;
//using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StudentMgmtServices
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configure(WebApiConfig.Register);

            UnityConfig.RegisterComponents();


            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            


        }
    }
}
