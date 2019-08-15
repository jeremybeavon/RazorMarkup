namespace RazorMarkup.Web.RawHtml
{
    public interface IAreaElement<TElement> : IHtmlElement<TElement>
        where TElement : IAreaElement<TElement>
    {
        TElement WithAlternateText(string text);

        TElement WithUrl(string url);

        TElement WithTarget(PageLinkTarget target);
    }
}
