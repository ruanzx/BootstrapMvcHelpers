using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Bootstrap.Mvc.Helpers
{
    public class Button : ComponentBase
    {
        public string Text { get; set; }

        public override string ToHtmlString()
        {
            TagBuilder builder = new TagBuilder("button");
            builder.MergeAttribute("name", Name, true);
            builder.InnerHtml = Text;

            return builder.ToString(TagRenderMode.Normal);
        }
    }
}
