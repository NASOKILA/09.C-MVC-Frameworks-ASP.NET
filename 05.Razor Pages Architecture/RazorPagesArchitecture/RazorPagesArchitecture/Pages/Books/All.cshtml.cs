namespace RazorPagesArchitecture.Pages.Books
{
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class AllModel : PageModel
    {
        public void OnGet(string param1, string param2)
        {
            ViewData["Params"] = param1 + " " + param2;
        }
    }
}