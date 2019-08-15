namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputTextElement : AbstractInputElement<IInputTextElement>, IInputTextElement
    {
        public InputTextElement()
            : base("text")
        {
        }

        public IInputTextElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputTextElement WithWidth(int numberOfCharacters)
        {
            return AddAttribute("size", numberOfCharacters.ToString());
        }
        
        public IInputTextElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
