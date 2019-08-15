namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputResetButtonElement : AbstractInputElement<IInputResetButtonElement>, IInputResetButtonElement
    {
        public InputResetButtonElement()
            : base("reset")
        {
        }

        public IInputResetButtonElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputResetButtonElement WithText(string text)
        {
            return AddAttribute("value", text);
        }
    }
}
