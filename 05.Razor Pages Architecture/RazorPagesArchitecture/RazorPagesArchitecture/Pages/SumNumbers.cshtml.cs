
namespace RazorPagesArchitecture.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class SumNumbersModel : PageModel
    {
        [BindProperty]
        public int FirstNumber { get; set; }

        [BindProperty]
        public int SecondNumber { get; set; }

        public int Sum { get; set; }
        
        public void OnGet()
        {
        }
        
        public void OnPostSumNumbers(string NumberOne, string NumberTwo) {
            
            this.Sum = this.FirstNumber + this.SecondNumber;   
        }

        public void OnPostIncrementSum() {
            this.Sum++;
        }
    }
}