using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSPXL2.TagHelpers
{
    [HtmlTargetElement("date-only")]
    public class DateTagHelper : TagHelper
    {

        public DateTime Date { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();

            sb.AppendFormat("<span>{0}</span>", Date.ToString("dd/MM/yyyy"));

            output.PreContent.SetHtmlContent(sb.ToString());
        } 



    }
}
