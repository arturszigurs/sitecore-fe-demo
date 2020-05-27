using Newtonsoft.Json;
using Sitecore.Data;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using SitecoreFeDemo.Models;
using SitecoreFeDemo.Models.Glass;
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

            //creates & populates viewModel
            var currentModule = new DefaultComponent();
            currentModule.Id = Guid.NewGuid();
            currentModule.componentType = RenderingContext.Current.Rendering.RenderingItem.Name.ToString();

            //builds data-json attribute contents in html.
            if (dataSource != null)
            {
                var componentContents = new ComponentContents();
                componentContents.title = dataSource.Fields["title"].ToString();
                componentContents.content = dataSource.Fields["content"].ToString();
                currentModule.datasourceContent = JsonConvert.SerializeObject(componentContents);
            }




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