using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;
using System.Net;

namespace ShoppingCart.Api
{
    public class ExceptionActionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger logger;
        public ExceptionActionFilter(ILogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// If an error occurred in controller side, It will pass it into this OnException function.
        /// </summary>
        /// <param name="context"></param>
        public override void OnException(ExceptionContext context)
        {
            var actionDescriptor = (ControllerActionDescriptor)context.ActionDescriptor;
            var controllerType = actionDescriptor.ControllerTypeInfo;

            var controllerBase = typeof(ControllerBase);
            var controller = typeof(Controller);

            if (controllerType.IsSubclassOf(controllerBase) && !controllerType.IsSubclassOf(controller)) 
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.HttpContext.Response.ContentType = "application/json";
                context.Result = new JsonResult(context.Exception.Message + "--" + context.HttpContext.Response.StatusCode);

                //Log exception message using SeriLog.
                this.logger.Error(context.Exception.Message.ToString());
            }
            base.OnException(context);
        }
    }
}
