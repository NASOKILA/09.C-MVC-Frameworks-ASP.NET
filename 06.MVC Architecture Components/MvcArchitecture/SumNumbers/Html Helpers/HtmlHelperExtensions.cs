using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SumNumbers.Html_Helpers
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlContent HelloWorld(this IHtmlHelper helper, string param) {

            return new HtmlString("<h1>Hello World " + param + "</h1>");
        }
    }
}
