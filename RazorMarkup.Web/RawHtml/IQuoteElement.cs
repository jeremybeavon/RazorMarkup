using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IQuoteElement : IHideObjectMethods
    {
        IBlockQuoteElement BeginBlock();

        IHtmlString EndBlock();

        IInlineQuoteElement BeginInline();

        IHtmlString EndInline();
    }
}
