namespace RazorMarkup.Web.RawHtml
{
    internal sealed class ListElements : IListElements
    {
        public IDescriptionListElements Description()
        {
            return new DescriptionListElements();
        }

        public IOrderedListElements Ordered()
        {
            return new OrderedListElements();
        }

        public IUnorderedListElements Unordered()
        {
            return new UnorderedListElements();
        }
    }
}
