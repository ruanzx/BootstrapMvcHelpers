using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bootstrap.Mvc.Helpers
{
    public abstract class ComponentBase
    {
        public string Name { get; set; }

        public abstract string ToHtmlString();
    }
}
