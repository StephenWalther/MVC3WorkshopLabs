using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace IPhoneCustomRoute.Models
{
    public class iPhoneRouteConstraint : IRouteConstraint
    {
        #region IRouteConstraint Members    
       
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {                  
            return (httpContext.Request.Browser.MobileDeviceModel == "IPhone");
        }

        #endregion
    }
}