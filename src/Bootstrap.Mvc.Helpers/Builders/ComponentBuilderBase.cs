using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Bootstrap.Mvc.Helpers.Builders
{
    public class ComponentBuilderBase<TComponent, TComponentBuilder> : IHtmlString
        where TComponent : ComponentBase
        where TComponentBuilder : ComponentBuilderBase<TComponent, TComponentBuilder>
    {
        protected TComponent Component { get; set; }

        public ComponentBuilderBase(TComponent component)
        {
            Component = component;
        }

        public string ToHtmlString()
        {
            return Component.ToHtmlString();
        }
    }
}
