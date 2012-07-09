using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Bootstrap.Mvc.Helpers
{
    public abstract class ComponentBase
    {
        private HtmlHelper htmlHelper;
        private string name;

        public HtmlHelper HtmlHelper
        {
            get
            {
                return htmlHelper;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public ComponentBase(HtmlHelper htmlHelper, string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentException("Value cannot be null or empty", "name");

            this.htmlHelper = htmlHelper;
            this.name = name;
        }

        public abstract string ToHtmlString();
    }
}
