namespace RazorMarkup.Web.RawHtml
{
    public interface IInlineFrameElement : IHtmlElement<IInlineFrameElement>
    {
        IInlineFrameElement WithHeight(int pixels);

        IInlineFrameElement WithName(string name);

        IInlineFrameElement WithUrl(string url);

        IInlineFrameElement WithWidth(int pixels);
    }
}
