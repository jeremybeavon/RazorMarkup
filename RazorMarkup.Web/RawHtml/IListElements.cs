namespace RazorMarkup.Web.RawHtml
{
    public interface IListElements : IHideObjectMethods
    {
        IDescriptionListElements Description();

        IOrderedListElements Ordered();

        IUnorderedListElements Unordered();
    }
}
