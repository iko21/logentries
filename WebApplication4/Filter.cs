using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace WebApplication4
{
    public class Filter
    {
        public class FilterExample : FilterAttribute, IActionFilter, IResultFilter, IExceptionFilter
        {
            private static ILog log = LogManager.GetLogger(typeof(FilterExample));

            public FilterExample()
            {
                log.Debug("FilterExample Usado");
            }

            public void OnActionExecuting(ActionExecutingContext filterContext)
            {
                log.Debug("Accion en Ejecuccion");
            }

            public void OnActionExecuted(ActionExecutedContext filterContext)
            {
                log.Warn("Accion Ejecutada");
            }

            public void OnResultExecuting(ResultExecutingContext filterContext)
            {
                log.Debug("Executando Resultado");
            }

            public void OnResultExecuted(ResultExecutedContext filterContext)
            {
                log.Warn("Resultado Ejecutado");
            }

            public void OnException(ExceptionContext filterContext)
            {
                log.Error("Algo salio mal. Culpo a Don Julio.");
            }
        }
    }
}