namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputEmailAddressElement : AbstractInputElement<IInputEmailAddressElement>, IInputEmailAddressElement
    {
        public InputEmailAddressElement()
            : base("email")
        {
        }

        public IInputEmailAddressElement WithAutocompleteOn()
        {
            return AddAttribute("autocomplete", "on");
        }

        public IInputEmailAddressElement WithAutocompleteOff()
        {
            return AddAttribute("autocomplete", "off");
        }
        
        public IInputEmailAddressElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputEmailAddressElement WithAllowMultiple()
        {
            return AddAttribute("multiple", "multiple");
        }
        
        public IInputEmailAddressElement WithRegularExpression(string pattern)
        {
            return AddAttribute("pattern", pattern);
        }

        public IInputEmailAddressElement WithPlaceholder(string text)
        {
            return AddAttribute("placeholder", text);
        }

        public IInputEmailAddressElement WithRequired()
        {
            return AddAttribute("required", "required");
        }
        
        public IInputEmailAddressElement WithWidth(int numberOfCharacters)
        {
            return AddAttribute("size", numberOfCharacters.ToString());
        }

        public IInputEmailAddressElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
