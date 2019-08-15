namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputTelephoneNumberElement : AbstractInputElement<IInputTelephoneNumberElement>, IInputTelephoneNumberElement
    {
        public InputTelephoneNumberElement()
            : base("tel")
        {
        }

        public IInputTelephoneNumberElement WithAutocompleteOn()
        {
            return AddAttribute("autocomplete", "on");
        }

        public IInputTelephoneNumberElement WithAutocompleteOff()
        {
            return AddAttribute("autocomplete", "off");
        }

        public IInputTelephoneNumberElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputTelephoneNumberElement WithRegularExpression(string pattern)
        {
            return AddAttribute("pattern", pattern);
        }

        public IInputTelephoneNumberElement WithPlaceholder(string text)
        {
            return AddAttribute("placeholder", text);
        }

        public IInputTelephoneNumberElement WithRequired()
        {
            return AddAttribute("required", "required");
        }

        public IInputTelephoneNumberElement WithWidth(int numberOfCharacters)
        {
            return AddAttribute("size", numberOfCharacters.ToString());
        }

        public IInputTelephoneNumberElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
