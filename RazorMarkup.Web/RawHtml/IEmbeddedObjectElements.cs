using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IEmbeddedObjectElements : IHideObjectMethods
    {
        IObjectElement Begin();

        IHtmlString End();

        IParameterElement Parameter();
    }
}
