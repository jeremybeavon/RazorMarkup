namespace RazorMarkup.Web.RawHtml
{
    public interface IOrderedListElement : IHtmlElement<IOrderedListElement>
    {
        IOrderedListElement WithStart(int startNumber);

        IOrderedListElement WithType(OrderedListType type);
    }
}
