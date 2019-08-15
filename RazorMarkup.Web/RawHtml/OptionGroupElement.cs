namespace RazorMarkup.Web.RawHtml
{
    internal sealed class OptionGroupElement : AbstractHtmlElement<IOptionGroupElement>, IOptionGroupElement
    {
        public OptionGroupElement()
            : base("optgroup", false)
        {
        }

        public IOptionGroupElement WithDisabled()
        {
            return AddEmptyAttribute("disabled");
        }

        public IOptionGroupElement WithText(string text)
        {
            return AddAttribute("label", text);
        }
    }
}
