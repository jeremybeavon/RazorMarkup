namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputWeekElement : AbstractInputElement<IInputWeekElement>, IInputWeekElement
    {
        public InputWeekElement()
            : base("Week")
        {
        }

        public IInputWeekElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputWeekElement WithMin(int year, int week)
        {
            return AddAttribute("min", string.Format("{0}-W{1}", year, week));
        }

        public IInputWeekElement WithMax(int year, int week)
        {
            return AddAttribute("max", string.Format("{0}-W{1}", year, week));
        }

        public IInputWeekElement WithValue(int year, int week)
        {
            return AddAttribute("value", string.Format("{0}-W{1}", year, week));
        }
    }
}
