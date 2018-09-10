
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace BookLibrary.Web.Helpers
{
    
    
    [HtmlTargetElement(Attributes="form-control")] 
    public class FormControlHelper : TagHelper
    { 
        private readonly IHtmlGenerator generator;

        public FormControlHelper(IHtmlGenerator generator)
        {
            this.generator = generator;
        }

       [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }
    
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"<div class=""form-group"">");
            sb.AppendLine(@"<h1>NASKO</h1>");

            sb.AppendLine(@"</div>");

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
