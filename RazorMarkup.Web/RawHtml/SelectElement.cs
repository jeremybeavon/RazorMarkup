namespace RazorMarkup.Web.RawHtml
{
    internal sealed class SelectElement : AbstractHtmlElement<ISelectElement>, ISelectElement
    {
        public SelectElement()
            : base("select", false)
        {
        }

        public ISelectElement WithDisabled()
        {
            return AddEmptyAttribute("disabled");
        }

        public ISelectElement WithMultipleSelections()
        {
            return AddEmptyAttribute("multiple");
        }

        public ISelectElement WithName(string name)
        {
            return AddAttribute("name", name);
        }

        public ISelectElement WithSize(int numberOfVisibleOptions)
        {
            return AddAttribute("size", numberOfVisibleOptions.ToString());
        }
    }
}
