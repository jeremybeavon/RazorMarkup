namespace RazorMarkup.Web.RawHtml
{
    internal sealed class OrderedListElement : AbstractHtmlElement<IOrderedListElement>, IOrderedListElement
    {
        public OrderedListElement()
            : base("ol", false)
        {
        }

        public IOrderedListElement WithStart(int startNumber)
        {
            return AddAttribute("start", startNumber.ToString());
        }

        public IOrderedListElement WithType(OrderedListType type)
        {
            return AddAttribute("type", type.ToHtmlString());
        }
    }
}
