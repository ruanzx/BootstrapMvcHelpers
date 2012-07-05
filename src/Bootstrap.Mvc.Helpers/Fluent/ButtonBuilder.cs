using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Bootstrap.Mvc.Helpers.Fluent
{
    public class ButtonBuilder : ComponentBuilderBase<Button>
    {
        public ButtonBuilder(Button button) 
            : base(button)
        {
        }

        public ButtonBuilder Name(string name)
        {
            Component.Name = name;

            return this;
        }

        public ButtonBuilder Text(string text)
        {
            Component.Text = text;

            return this;
        }
    }
}
