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

        }

        public ActionResult ShowComponent()
        {
            //gets rendering datasource
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);

            //creates model.
            var currentModule = new DefaultComponent();
            currentModule.Id = Guid.NewGuid();
            currentModule.componentType = RenderingContext.Current.Rendering.RenderingItem.Name.ToString();

            //for demo purposes, sets default content.
            currentModule.datasourceContent = "";


            //adds model to httpContext
            var modules = HttpContext.GetSitecoreModules();
            if (modules == null)
            {
                modules = new List<DefaultComponent>();
            }
            modules.Add(currentModule);

            HttpContext.Items["SitecoreModules"] = modules;


            return View("~/Views/DefaultComponent.cshtml", currentModule);
        }
    }
}