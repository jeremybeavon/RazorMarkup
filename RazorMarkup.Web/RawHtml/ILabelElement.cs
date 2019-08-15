namespace RazorMarkup.Web.RawHtml
{
    public interface ILabelElement : IHtmlElement<ILabelElement>
    {
        ILabelElement WithBindTo(string elementId);
    }
}
