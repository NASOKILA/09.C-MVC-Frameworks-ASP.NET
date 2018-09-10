using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FiltersLesson.Filters
{
    [AttributeUsage(AttributeTargets.Method)] 
    public class CensorNumberAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Form.ContainsKey("FirstNumber") && context.HttpContext.Request.Form.ContainsKey("SecondNumber"))
            {
                var firstNumber = context.HttpContext.Request.Form["FirstNumber"][0];
                var secondNumber = context.HttpContext.Request.Form["SecondNumber"][0];
            }

            base.OnActionExecuting(context);
        }
    }
}
