using FiltersLesson.Services;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersLesson.Filters
{
   public class LoggingFilter : IActionFilter
    {
        private readonly LoggingInfoService loggingInfoService;

        public LoggingFilter(LoggingInfoService loggingInfoService)
        {
            this.loggingInfoService = loggingInfoService;
        }
        
        public void OnActionExecuting(ActionExecutingContext context)
        {
           string displayName = context.ActionDescriptor.DisplayName; 
            string method = context.HttpContext.Request.Method;

            this.loggingInfoService.Messages.Add($"Executing {displayName} with method {method}.");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

            string displayName = context.ActionDescriptor.DisplayName; 
            string method = context.HttpContext.Request.Method; 

            this.loggingInfoService.Messages.Add($"Executing {displayName} with method {method}.");
        }

    }
}
