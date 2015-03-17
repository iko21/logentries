using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using log4net.Core;

namespace WebApplication4.Controllers
{
    public class LoginAttribute:FilterAttribute,IActionFilter
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(LoginAttribute));
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var s= filterContext.ActionDescriptor.ActionName;
            logger.Info(s);
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //comment
        }
    }
}