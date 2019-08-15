namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputButtonElement : AbstractInputElement<IInputButtonElement>, IInputButtonElement
    {
        public InputButtonElement()
            : base("button")
        {
        }

        public IInputButtonElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputButtonElement WithText(string text)
        {
            return AddAttribute("value", text);
        }
    }
}
