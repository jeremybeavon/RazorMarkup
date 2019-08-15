namespace RazorMarkup.Web.RawHtml
{
    public interface IObjectElement : IHtmlElement<IObjectElement>
    {
        IObjectElement WithUrl(string url);

        IObjectElement WithHeight(int pixels);

        IObjectElement WithName(string name);

        /// <summary>
        /// Specifies the media type of data specified in the data attribute. See MediaType class.
        /// </summary>
        IObjectElement WithType(string type);

        IObjectElement WithImageMap(string name);

        IObjectElement WithWidth(int pixels);
    }
}
