namespace RazorPagesArchitecture.Pages
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        [Required]
        [MinLength(3)]
        [DataType(DataType.Text)]
        [BindProperty(SupportsGet=true)]  
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        [BindProperty(SupportsGet = true)] 
        public string Password { get; set; }

        public void OnPost(string username, string password)
        {
            if (this.ModelState.IsValid)
            {
                ViewData["Username"] = this.Username;
                ViewData["Password"] = this.Password;
            }
            else
            {
                ViewData["Error"] = "Invalid Form Input!";
            }
        }
    }
}


