namespace RazorMarkup.Web.RawHtml
{
    internal abstract class AbstractAreaElement<TElement> : AbstractHtmlElement<TElement>, IAreaElement<TElement>
        where TElement : IAreaElement<TElement>
    {
        public AbstractAreaElement(string shape)
            : base("area", true)
        {
            AddAttribute("shape", shape);
        }

        public TElement WithAlternateText(string text)
        {
            return AddAttribute("alt", text);
        }

        public TElement WithUrl(string url)
        {
            return AddAttribute("href", url);
        }

        public TElement WithTarget(PageLinkTarget target)
        {
            return AddAttribute("target", target.ToHtmlString());
        }
    }
}
