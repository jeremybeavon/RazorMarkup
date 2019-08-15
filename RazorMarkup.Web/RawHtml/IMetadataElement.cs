namespace RazorMarkup.Web.RawHtml
{
    public interface IMetadataElement : IHtmlElement<IMetadataElement>
    {
        IMetadataElement WithContent(string content);

        IMetadataElement WithName(HttpMetadataName name);

        IMetadataElement WithName(MetadataName name);
    }
}
