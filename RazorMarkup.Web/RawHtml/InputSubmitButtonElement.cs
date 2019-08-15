namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputSubmitButtonElement : AbstractInputElement<IInputSubmitButtonElement>, IInputSubmitButtonElement
    {
        public InputSubmitButtonElement()
            : base("submit")
        {
        }

        public IInputSubmitButtonElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }

        public IInputSubmitButtonElement WithText(string text)
        {
            return AddAttribute("value", text);
        }
    }
}
