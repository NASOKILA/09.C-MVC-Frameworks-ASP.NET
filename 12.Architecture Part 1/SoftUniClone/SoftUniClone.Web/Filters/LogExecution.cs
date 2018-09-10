using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SoftUniClone.Web.Filters
{
    public class LogExecution : IPageFilter, IActionFilter
    {
        private ILogger<LogExecution> logger;
        private Stopwatch stopwatch;

        public LogExecution(ILogger<LogExecution> logger, Stopwatch stopwatch)
        {
            this.logger = logger;   
            this.stopwatch = stopwatch;
        }
        
        public void OnActionExecuting(ActionExecutingContext context)
        {                                            
            this.LogEnteringMessage(context.HttpContext.Request.Method, context.ActionDescriptor.DisplayName, context.ModelState.IsValid);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            this.LogLeavingMessage();
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {

        }
        
        private void LogEnteringMessage(string httpMethod, string actionName, bool isModelValid) {
            
            this.logger.LogInformation($"Executing {httpMethod} {actionName}.");
            this.logger.LogInformation($"Model state {(isModelValid ? "is" : "is not")} valid.");

            this.stopwatch.Start();
        }

        private void LogLeavingMessage()
        {   
            this.stopwatch.Stop();
            var time = this.stopwatch.Elapsed.TotalSeconds;
        }
    }
}
