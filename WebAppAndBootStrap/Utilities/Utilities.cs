using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppAndBootStrap.Utilities
{
    public static class Utilities
    {
        public static string IsActive(this HtmlHelper html, string control, string action)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = routeData.Values["action"] as string;
            var routeControl = routeData.Values["controller"] as string;

            var isActive = control == routeControl && action == routeAction;

            return isActive ? "active" : "";
        }
    }
}