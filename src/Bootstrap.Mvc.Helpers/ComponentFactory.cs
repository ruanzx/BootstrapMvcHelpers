using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Bootstrap.Mvc.Helpers.Fluent;
using System.Linq.Expressions;

namespace Bootstrap.Mvc.Helpers
{
    public class ComponentFactory
    {
        public HtmlHelper HtmlHelper { get; set; }

        public ComponentFactory(HtmlHelper htmlHelper)
        {
            this.HtmlHelper = htmlHelper;
        }

        public ButtonBuilder Button()
        {
            return new ButtonBuilder(new Button());
        }
    }

    public class ComponentFactory<TModel> : ComponentFactory
    {
        public HtmlHelper<TModel> HtmlHelper { get; set; }

        public ComponentFactory(HtmlHelper<TModel> htmlHelper)
            : base(htmlHelper)
        {
            this.HtmlHelper = htmlHelper;
        }
    }
}
