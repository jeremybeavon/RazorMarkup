namespace RazorMarkup.Web.RawHtml
{
    internal sealed class ImageElement : AbstractHtmlElement<IImageElement>, IImageElement
    {
        public ImageElement()
            : base("img", true)
        {
        }

        public IImageElement WithAlternateText(string text)
        {
            return AddAttribute("alt", text);
        }

        public IImageElement WithHeight(int pixels)
        {
            return AddAttribute("height", pixels.ToString());
        }

        public IImageElement WithUrl(string url)
        {
            return AddAttribute("src", url);
        }

        public IImageElement WithImageMap(string name)
        {
            return AddAttribute("usemap", "#" + name);
        }

        public IImageElement WithWidth(int pixels)
        {
            return AddAttribute("width", pixels.ToString());
        }
    }
}
