using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Bootstrap.Mvc.Helpers
{
    public class InputButton : ButtonBase
    {
        protected override string TagName
        {
            get { return "input"; }
        }

        public InputButton(HtmlHelper htmlHelper, string name)
            : base(htmlHelper, name)
        {

        }
    }
}
