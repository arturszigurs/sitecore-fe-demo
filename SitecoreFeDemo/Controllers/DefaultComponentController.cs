using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using SitecoreFeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreFeDemo.Controllers
{
    public class DefaultComponentController : SitecoreController
    {
        public DefaultComponentController()

        {
            //gets rendering datasource
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);

            //creates model.
            var currentModule = new DefaultComponent();
            currentModule.datasourceContent = dataSource.ToString() ;

            //adds model to httpContext.
            var modules = HttpContext.GetSitecoreModules();
            modules.Add(currentModule);

            HttpContext.Items["SitecoreModules"] = modules;
        }

        public ActionResult ShowComponent()
        {
            return View();
        }
    }
}