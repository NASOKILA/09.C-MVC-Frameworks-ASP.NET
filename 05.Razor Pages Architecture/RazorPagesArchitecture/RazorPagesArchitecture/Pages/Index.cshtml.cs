namespace RazorPagesArchitecture.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System;

   
    public class IndexModel : PageModel 
    {

        public IActionResult OnGet()
        {
            this.Boxing();

            return Page(); 
        }
        
        public void OnPostMessageOne()
        {
            ViewData["Message"] = "Message One!";
        }

        public void OnPostMessageTwo()
        {
            ViewData["Message"] = "Message Two!";
        }
        
        public void OnPostParametersPassed(string name)
        {
            ViewData["Greeting"] = "Hello, " + name;
        }

        public void OnGetLinkClicked()
        {
            ViewData["LinkMessage"] += "Link is clicked.";
        }

       
        public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            ViewData["LinkMessage"] += "OnPageSelected " + context.HandlerMethod.Name;
            base.OnPageHandlerSelected(context);
        }

        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            ViewData["LinkMessage"] += "OnPageExecuting " + context.HandlerMethod.Name;
            base.OnPageHandlerExecuting(context);
        }

        public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            ViewData["LinkMessage"] += "OnPageExecuted " + context.HandlerMethod.Name + Environment.NewLine;
            base.OnPageHandlerExecuted(context);
        }

        public void Boxing() {
 
            int a = 5;
            object aObj = (object)a;

            int b = (int)aObj - 1;

            int? c = null;
            Console.WriteLine(c);
        }
    }
}
