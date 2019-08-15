namespace RazorMarkup.Web.RawHtml
{
    public interface IInputElement<TElement> : IHtmlElement<TElement>
        where TElement : IInputElement<TElement>
    {
        TElement WithReadonly();

        TElement WithName(HtmlName name);
    }
}
