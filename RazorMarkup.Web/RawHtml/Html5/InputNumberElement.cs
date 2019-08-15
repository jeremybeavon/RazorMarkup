namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputNumberElement : AbstractInputElement<IInputNumberElement>, IInputNumberElement
    {
        public InputNumberElement()
            : base("number")
        {
        }

        public IInputNumberElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputNumberElement WithMax(double max)
        {
            return AddAttribute("max", max.ToString());
        }

        public IInputNumberElement WithMin(double min)
        {
            return AddAttribute("min", min.ToString());
        }
        
        public IInputNumberElement WithRequired()
        {
            return AddAttribute("required", "required");
        }

        public IInputNumberElement WithStep(double step)
        {
            return AddAttribute("step", step.ToString());
        }

        public IInputNumberElement WithValue(double value)
        {
            return AddAttribute("value", value.ToString());
        }
    }
}
