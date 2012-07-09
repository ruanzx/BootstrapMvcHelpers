using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Bootstrap.Mvc.Helpers.Builders;
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

        public ButtonBuilder Button(string name)
        {
            return new ButtonBuilder(new Button(HtmlHelper, name));
        }

        public InputButtonBuilder InputButton(string name)
        {
            return new InputButtonBuilder(new InputButton(HtmlHelper, name));
        }

        public LinkButtonBuilder LinkButton(string name)
        {
            return new LinkButtonBuilder(new LinkButton(HtmlHelper, name));
        }
    }

    public class ComponentFactory<TModel> : ComponentFactory
    {
        //public HtmlHelper<TModel> HtmlHelper { get; set; }

        public ComponentFactory(HtmlHelper<TModel> htmlHelper)
            : base(htmlHelper)
        {
            //this.HtmlHelper = htmlHelper;
        }
    }
}
