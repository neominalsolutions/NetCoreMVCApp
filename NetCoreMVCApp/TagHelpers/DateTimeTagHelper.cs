using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.TagHelpers
{

    // html element ismi
    // html attribute için kebabcase format önerilirken 
    // property isimleri için camelCase kullanılmalıdır.
    [HtmlTargetElement("asp-datetime",Attributes="date-time")]
    public class DateTimeTagHelper: TagHelper
    {
        // <datetime></datetime>


        // attribute üzerinden gelen değerin aktarılacağı property
        public DateTime dateTime { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.TagName = "span";
            output.Attributes.SetAttribute("class", "alert alert-info");
            output.Content.SetHtmlContent($"{dateTime.ToShortDateString()} - {dateTime.ToShortTimeString()}");

            // bu method içerisinde html çıktısı output ile üretiriz.
            base.Process(context, output);
        }
    }
}
