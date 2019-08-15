using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class EmbeddedObjectElements : IEmbeddedObjectElements
    {
        public IObjectElement Begin()
        {
            return new ObjectElement();
        }

        public IHtmlString End()
        {
            return new HtmlString("</object>");
        }

        public IParameterElement Parameter()
        {
            return new ParameterElement();
        }
    }
}
