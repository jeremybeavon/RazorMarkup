using System.Web;

namespace RazorMarkup.Web
{
    public abstract class AbstractHtmlString : IHtmlString
    {
        public abstract string ToHtmlString();

        public override string ToString()
        {
            return ToHtmlString();
        }
    }
}
