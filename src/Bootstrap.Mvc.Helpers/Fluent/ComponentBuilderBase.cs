using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Bootstrap.Mvc.Helpers.Fluent
{
    public class ComponentBuilderBase<TComponent> : IHtmlString where TComponent: ComponentBase
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
