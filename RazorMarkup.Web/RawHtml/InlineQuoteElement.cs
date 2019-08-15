namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InlineQuoteElement : AbstractHtmlElement<IInlineQuoteElement>, IInlineQuoteElement
    {
        public InlineQuoteElement()
            : base("q", false)
        {
        }

        public IInlineQuoteElement WithCite(string source)
        {
            return AddAttribute("cite", source);
        }
    }
}
