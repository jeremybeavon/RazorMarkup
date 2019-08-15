namespace RazorMarkup.Web.RawHtml.Html5
{
    public sealed class MeterElement : AbstractHtmlElement<IMeterElement>, IMeterElement
    {
        public MeterElement()
            : base("meter", false)
        {
        }

        public IMeterElement WithForm(string formId)
        {
            return AddAttribute("form", formId);
        }

        public IMeterElement WithHighValue(double highValue)
        {
            return AddAttribute("high", highValue.ToString());
        }

        public IMeterElement WithLowValue(double lowValue)
        {
            return AddAttribute("low", lowValue.ToString());
        }

        public IMeterElement WithMaxValue(double maxValue)
        {
            return AddAttribute("max", maxValue.ToString());
        }

        public IMeterElement WithMinValue(double minValue)
        {
            return AddAttribute("min", minValue.ToString());
        }

        public IMeterElement WithOptimumValue(double optimumValue)
        {
            return AddAttribute("optimum", optimumValue.ToString());
        }

        public IMeterElement WithValue(double value)
        {
            return AddAttribute("value", value.ToString());
        }
    }
}
