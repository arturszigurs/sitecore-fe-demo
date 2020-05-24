using SitecoreFeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore;

public static class HttpContextExtensions
{
    public static List<DefaultComponent> GetSitecoreModules(this HttpContextBase context)
    {
        return (List<DefaultComponent>)context.Items["SitecoreModules"];
    }

}