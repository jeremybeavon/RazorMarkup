namespace RazorMarkup.Web.RawHtml
{
    internal sealed class BlockQuoteElement : AbstractHtmlElement<IBlockQuoteElement>, IBlockQuoteElement
    {
        public BlockQuoteElement()
            : base("blockquote", false)
        {
        }

        public IBlockQuoteElement WithCite(string source)
        {
            return AddAttribute("cite", source);
        }
    }
}
