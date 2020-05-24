using Newtonsoft.Json;
using Sitecore.Mvc.Helpers;
using SitecoreFeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreFeDemo.Helpers
{
    public static class SitecoreRenderingDatasourceHelper
    {
        //public static MvcHtmlString GetExtensionMethodString(this SitecoreHelper helper)
        public static string RenderDatasourceContents(this SitecoreHelper helper)
        {
            if (HttpContext.Current.Items["SitecoreModules"] != null)
            {
                var modules = (List<DefaultComponent>)HttpContext.Current.Items["SitecoreModules"];
                var json = JsonConvert.SerializeObject(modules);

                return json.ToString();

            }
            else
            {
                return null;
            }
        }
    }
}
