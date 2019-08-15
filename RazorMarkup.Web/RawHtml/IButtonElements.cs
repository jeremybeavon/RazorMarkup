using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IButtonElements : IHideObjectMethods
    {
        IInputSubmitButtonElement Submit();

        IInputImageButtonElement Image(string imageUrl);

        IInputResetButtonElement Reset();

        IInputButtonElement Inline();

        IButtonElement Begin();

        IHtmlString End();
    }
}
