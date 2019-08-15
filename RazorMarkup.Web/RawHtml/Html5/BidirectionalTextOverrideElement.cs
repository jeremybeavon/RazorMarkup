using System;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class BidirectionalTextOverrideElement :
        AbstractHtmlElement<IBidirectionalTextOverrideElement>, IBidirectionalTextOverrideElement
    {
        public BidirectionalTextOverrideElement()
            : base("bdo", false)
        {
        }

        public IBidirectionalTextOverrideElement WithTextDirection(TextDirectionOverride textDirection)
        {
            string textDirectionText;
            switch (textDirection)
            {
                case TextDirectionOverride.LeftToRight:
                    textDirectionText = "ltr";
                    break;
                case TextDirectionOverride.RightToLeft:
                    textDirectionText = "rtl";
                    break;
                    default:
                    throw new ArgumentException("text direction was not supported: " + textDirection, "textDirection");

            }

            return AddAttribute("dir", textDirectionText);
        }
    }
}
