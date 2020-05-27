using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreFeDemo.Models
{
    public class DefaultComponent
    {
        public Guid Id { get; set; }

        public string componentType { get; set; }

        public string datasourceContent { get; set; }
    }
}