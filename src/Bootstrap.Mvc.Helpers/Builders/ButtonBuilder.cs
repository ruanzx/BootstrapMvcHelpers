using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bootstrap.Mvc.Helpers;

namespace Bootstrap.Mvc.Helpers.Builders
{
    public class ButtonBuilder : ButtonBuilderBase<Button, ButtonBuilder>
    {
        public ButtonBuilder(Button button)
            : base(button)
        {

        }

        public ButtonBuilder ButtonType(ButtonType buttonType)
        {
            Component.ButtonType = buttonType;

            return this;
        }
    }
}
