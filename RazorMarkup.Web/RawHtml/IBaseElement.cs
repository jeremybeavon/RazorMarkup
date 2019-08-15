namespace RazorMarkup.Web.RawHtml
{
    public interface IBaseElement : IHtmlElement<IBaseElement>
    {
        IBaseElement WithUrl(string url);

        IBaseElement WithTarget(PageLinkTarget target);
    }
}
