namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputFileElement : AbstractInputElement<IInputFileElement>, IInputFileElement
    {
        public InputFileElement()
            : base("file")
        {
        }

        public IInputFileElement WithFileExtension(params string[] fileExtensions)
        {
            return AddAttribute("accept", string.Join(",", fileExtensions));
        }
        
        public IInputFileElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
    }
}
