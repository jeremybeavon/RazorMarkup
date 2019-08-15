using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class  ButtonElements : IButtonElements
    {
        public IInputSubmitButtonElement Submit()
        {
            return new InputSubmitButtonElement();
        }

        public IInputImageButtonElement Image(string imageUrl)
        {
            return new InputImageButtonElement(imageUrl);
        }

        public IInputResetButtonElement Reset()
        {
            return new InputResetButtonElement();
        }

        public IInputButtonElement Inline()
        {
            return new InputButtonElement();
        }

        public IButtonElement Begin()
        {
            return new ButtonElement();
        }

        public IHtmlString End()
        {
            return new HtmlString("</button>");
        }
    }
}
