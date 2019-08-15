namespace RazorMarkup.Web.RawHtml
{
    internal sealed class MetadataElement : AbstractHtmlElement<IMetadataElement>, IMetadataElement
    {
        public MetadataElement()
            : base("meta", true)
        {
        }

        public IMetadataElement WithContent(string content)
        {
            return AddAttribute("content", content);
        }

        public IMetadataElement WithName(HttpMetadataName name)
        {
            return AddAttribute("http-equiv", name.ToHtmlString());
        }

        public IMetadataElement WithName(MetadataName name)
        {
            return AddAttribute("name", name.ToHtmlString());
        }
    }
}
