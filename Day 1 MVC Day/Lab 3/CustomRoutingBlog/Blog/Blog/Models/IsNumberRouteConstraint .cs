using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Text.RegularExpressions;

namespace Blog.Models
{
    public class IsNumberRouteConstraint : IRouteConstraint
    {
        #region IRouteConstraint Members

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var paramValue = values[parameterName].ToString();
            return Regex.IsMatch(paramValue, @"\d+");
        }

        #endregion
    }
}