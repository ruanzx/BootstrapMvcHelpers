using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Bootstrap.Mvc.Helpers.Builders
{
    public class ButtonBuilderBase<TButton, TButtonBuilder> : ComponentBuilderBase<TButton, TButtonBuilder>
        where TButton : ButtonBase
        where TButtonBuilder : ButtonBuilderBase<TButton, TButtonBuilder>
    {
        public ButtonBuilderBase(TButton button) 
            : base(button)
        {
        }

        public TButtonBuilder Enabled(bool enabled)
        {
            Component.Enabled = enabled;

            return (TButtonBuilder)this;
        }

        public TButtonBuilder Size(ButtonSize size)
        {
            Component.Size = size;

            return (TButtonBuilder)this;
        }

        public TButtonBuilder Style(ButtonStyle style)
        {
            Component.Style = style;

            return (TButtonBuilder)this;
        }

        public TButtonBuilder Text(string text)
        {
            Component.Text = text;

            return (TButtonBuilder)this;
        }
    }
}
