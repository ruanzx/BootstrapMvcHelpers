using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Bootstrap.Mvc.Helpers
{
    public static class BootstrapExtensions
    {
        public static ComponentFactory Bootstrap(this HtmlHelper html)
        {
            return new ComponentFactory(html);
        }

        public static ComponentFactory<TModel> Bootstrap<TModel>(this HtmlHelper<TModel> html)
        {
            return new ComponentFactory<TModel>(html);
        }
    }
}