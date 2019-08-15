using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IDropDown : IHideObjectMethods
    {
        ISelectElement Begin();

        IHtmlString End();

        IOptionGroupElement BeginOptionGroup();

        IHtmlString EndOptionGroup();

        IOptionElement BeginOption();

        IHtmlString EndOption();
    }
}
