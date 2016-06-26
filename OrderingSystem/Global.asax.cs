using DAL;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TestProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            LoadLog4netConfig();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DbEntities>());
        }
        /// <summary>
        /// 配置Log4Net
        /// </summary>
        private void LoadLog4netConfig()
        {
            string filePath = Server.MapPath("~/Config/Log4net.config");
            FileInfo fileInfo = new FileInfo(filePath);
            //DOMConfigurator已经被XmlConfigurator取代
            //log4net.Config.DOMConfigurator.Configure(fileInfo);
            XmlConfigurator.ConfigureAndWatch(fileInfo);
        }
    }
}
