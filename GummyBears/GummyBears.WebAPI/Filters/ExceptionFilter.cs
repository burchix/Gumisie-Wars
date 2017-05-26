using System;
using System.Web.Http.Filters;

namespace GummyBears.WebAPI.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception is NotImplementedException)
            {
            }
        }
    }
}