using Sitecore.Mvc.Helpers;
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
            return HttpContext.Current.GetSitecoreModules();
        }
    }
}
