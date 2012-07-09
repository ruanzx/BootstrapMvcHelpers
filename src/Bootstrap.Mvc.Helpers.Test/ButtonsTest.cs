using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using System.Web.Mvc;
using Bootstrap.Mvc.Helpers.Test.Util;
using Xunit.Extensions;

namespace Bootstrap.Mvc.Helpers.Test
{
    public class ButtonsTest
    {
        [Fact]
        public void ButtonWithEmptyNameThrows()
        {
            // Arrange
            HtmlHelper helper = MvcHelper.GetHtmlHelper();

            // Act
            Assert.Throws<ArgumentException>(() =>
            {
                helper.Bootstrap().Button("");
            });
        }

        [Fact]
        public void ButtonWithNullNameThrows()
        {
            // Arrange
            HtmlHelper helper = MvcHelper.GetHtmlHelper();

            // Act
            Assert.Throws<ArgumentException>(() =>
            {
                helper.Bootstrap().Button(null);
            });
        }

        [Fact]
        public void ButtonWithNameAndTextRenders()
        {
            // Arrange
            HtmlHelper helper = MvcHelper.GetHtmlHelper();

            // Act
            string html = helper.Bootstrap()
                .Button("hello")
                .Text("Hello World!!")
                .ToHtmlString();

            // Assert
            Assert.Equal(@"<button class=""btn"" name=""hello"">Hello World!!</button>", html);
        }

        [Theory,
        InlineData(ButtonSize.Large, @"<button class=""btn btn-large"" name=""hello""></button>"),
        InlineData(ButtonSize.Mini, @"<button class=""btn btn-mini"" name=""hello""></button>"),
        InlineData(ButtonSize.Small, @"<button class=""btn btn-small"" name=""hello""></button>"),
        InlineData(ButtonSize.Standard, @"<button class=""btn"" name=""hello""></button>")]
        public void ButtonSizeRenders(ButtonSize buttonSize, string expectedOutput)
        {
            // Arrange
            HtmlHelper helper = MvcHelper.GetHtmlHelper();

            // Act
            string html = helper.Bootstrap()
                .Button("hello")
                .Size(buttonSize)
                .ToHtmlString();

            // Assert
            Assert.Equal(expectedOutput, html);
        }
    }
}
