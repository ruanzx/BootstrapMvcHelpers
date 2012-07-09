using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bootstrap.Mvc.Helpers.Builders
{
    public class LinkButtonBuilder : ButtonBuilderBase<LinkButton, LinkButtonBuilder>
    {
        public LinkButtonBuilder(LinkButton button)
            : base(button)
        {
        }
    }
}
