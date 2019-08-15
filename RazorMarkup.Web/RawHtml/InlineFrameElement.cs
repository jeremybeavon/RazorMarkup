namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InlineFrameElement : AbstractHtmlElement<IInlineFrameElement>, IInlineFrameElement
    {
        public InlineFrameElement()
            : base("iframe", false)
        {
        }

        public IInlineFrameElement WithHeight(int pixels)
        {
            return AddAttribute("height", pixels.ToString());
        }

        public IInlineFrameElement WithName(string name)
        {
            return AddAttribute("name", name);
        }

        public IInlineFrameElement WithUrl(string url)
        {
            return AddAttribute("src", url);
        }

        public IInlineFrameElement WithWidth(int pixels)
        {
            return AddAttribute("width", pixels.ToString());
        }
    }
}
