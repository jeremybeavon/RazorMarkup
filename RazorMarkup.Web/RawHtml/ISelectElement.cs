namespace RazorMarkup.Web.RawHtml
{
    public interface ISelectElement : IHtmlElement<ISelectElement>
    {
        ISelectElement WithDisabled();

        ISelectElement WithMultipleSelections();

        ISelectElement WithName(string name);

        ISelectElement WithSize(int numberOfVisibleOptions);
    }
}
