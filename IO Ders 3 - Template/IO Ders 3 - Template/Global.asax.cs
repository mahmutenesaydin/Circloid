using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IO_Ders_3___Template
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            //JobConfig.StartJobServer(ref backgroundJobServer);
        }

        protected void Session_Start()
        {
            if (Application["ActiveMember"] == null)
            {
                int sayac = 1;
                Application["ActiveMember"] = sayac;
            }
            else
            {
                int sayac = (int)Application["ActiveMember"];
                sayac++;
                Application["ActiveMember"] = sayac;
            }

            if (Application["TotalVisitors"] == null)
            {
                int sayac = 1;
                Application["TotalVisitors"] = sayac;
            }
            else
            {
                int sayac = (int)Application["TotalVisitors"];
                sayac++;
                Application["TotalVisitors"] = sayac;
            }
        }

        protected void Session_End()
        {
            int sayac = (int)Application["ActiveMember"];
            sayac--;
            Application["ActiveMember"] = sayac;
        }
    }
}
