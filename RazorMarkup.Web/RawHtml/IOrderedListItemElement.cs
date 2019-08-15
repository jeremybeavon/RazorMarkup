namespace RazorMarkup.Web.RawHtml
{
    public interface IOrderedListItemElement : IHtmlElement<IOrderedListItemElement>
    {
        IOrderedListItemElement WithValue(int value);
    }
}
