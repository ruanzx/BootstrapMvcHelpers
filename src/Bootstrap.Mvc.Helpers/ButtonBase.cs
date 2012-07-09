using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Bootstrap.Mvc.Helpers
{
    public abstract class ButtonBase : ComponentBase
    {
        public bool Enabled { get; set; }
        public ButtonSize Size { get; set; }
        public ButtonStyle Style { get; set; }
        public string Text { get; set; }
        protected abstract string TagName { get; }

        public ButtonBase(HtmlHelper htmlHelper, string name)
            : base(htmlHelper, name)
        {
            Enabled = true;
            Size = ButtonSize.Standard;
            Style = ButtonStyle.Default;
        }

        private void ApplyClasses(List<string> classes)
        {
            ApplyEnabledClasses(classes);
            ApplySizeClasses(classes);
            ApplyStyleClasses(classes);
        }

        protected void ApplyEnabledClasses(List<String> classes)
        {
            if (!Enabled)
                classes.Add("disabled");
        }

        protected void ApplySizeClasses(List<string> classes)
        {
            switch (Size)
            {
                case ButtonSize.Large:
                    classes.Add("btn-large");
                    break;
                case ButtonSize.Mini:
                    classes.Add("btn-mini");
                    break;
                case ButtonSize.Small:
                    classes.Add("btn-small");
                    break;
                case ButtonSize.Standard:
                default:
                    break;
            }
        }

        protected void ApplyStyleClasses(List<string> classes)
        {
            switch (Style)
            {
                case ButtonStyle.Primary:
                    classes.Add("btn-primary");
                    break;
                case ButtonStyle.Info:
                    classes.Add("btn-info");
                    break;
                case ButtonStyle.Success:
                    classes.Add("btn-success");
                    break;
                case ButtonStyle.Warning:
                    classes.Add("btn-warning");
                    break;
                case ButtonStyle.Danger:
                    classes.Add("btn-danger");
                    break;
                case ButtonStyle.Inverse:
                    classes.Add("btn-inverse");
                    break;
                case ButtonStyle.Default:
                default:
                    break;
            }
        }

        public override string ToHtmlString()
        {
            string fullName = HtmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(Name);

            List<string> classes = new List<string> { "btn" };
            ApplyClasses(classes);

            TagBuilder builder = new TagBuilder(TagName);
            builder.MergeAttribute("name", fullName, true);
            builder.MergeAttribute("class", String.Join(" ", classes), true);
            builder.InnerHtml = Text;

            return builder.ToString(TagRenderMode.Normal);
        }
    }
}
