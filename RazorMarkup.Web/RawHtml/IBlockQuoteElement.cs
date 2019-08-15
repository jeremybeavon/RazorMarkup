namespace RazorMarkup.Web.RawHtml
{
    public interface IBlockQuoteElement : IHtmlElement<IBlockQuoteElement>
    {
        /// <summary>
        /// Specifies the source of the quotation
        /// </summary>
        IBlockQuoteElement WithCite(string source);
    }
}
