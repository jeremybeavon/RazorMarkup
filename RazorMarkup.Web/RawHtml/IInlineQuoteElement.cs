namespace RazorMarkup.Web.RawHtml
{
    public interface IInlineQuoteElement : IHtmlElement<IInlineQuoteElement>
    {
        /// <summary>
        /// Specifies the source of the quotation
        /// </summary>
        IInlineQuoteElement WithCite(string source);
    }
}
