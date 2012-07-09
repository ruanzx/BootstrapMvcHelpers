using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Bootstrap.Mvc.Helpers
{
    public class Button : ButtonBase
    {
        public ButtonType ButtonType { get; set; }

        protected override string TagName
        {
            get { return "button"; }
        }

        public Button(HtmlHelper htmlHelper, string name)
            : base(htmlHelper, name)
        {
            ButtonType = ButtonType.Button;
        }
    }
}
