using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSPXL2.TagHelpers
{
    [HtmlTargetElement("currency")]
    public class PriceTagHelper : TagHelper
    {

        public string Currency { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();

            sb.AppendFormat("<span><em>€{0}</em></span>", Currency);

            output.PreContent.SetHtmlContent(sb.ToString());
        }

    }
}
