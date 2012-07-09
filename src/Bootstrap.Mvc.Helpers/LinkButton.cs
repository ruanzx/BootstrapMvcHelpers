using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Bootstrap.Mvc.Helpers
{
    public class LinkButton : ButtonBase
    {
        protected override string TagName
        {
            get { return "a"; }
        }

        public LinkButton(HtmlHelper htmlHelper, string name)
            : base(htmlHelper, name)
        {

        }
    }
}
