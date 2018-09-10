using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SumNumbers.TagHelpers
{
    public class MessageTagHelper : TagHelper
    {
        public string MessageContent { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetContent(this.MessageContent);
        }
    }
}
