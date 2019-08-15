namespace RazorMarkup.Web.RawHtml
{
    internal sealed class LabelElement : AbstractHtmlElement<ILabelElement>, ILabelElement
    {
        public LabelElement()
            : base("label", false)
        {
        }

        public ILabelElement WithBindTo(string elementId)
        {
            return AddAttribute("for", elementId);
        }
    }
}
