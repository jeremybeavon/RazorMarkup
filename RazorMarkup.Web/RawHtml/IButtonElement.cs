namespace RazorMarkup.Web.RawHtml
{
    public interface IButtonElement : IHtmlElement<IButtonElement>
    {
        IButtonElement WithDisabled();

        IButtonElement WithName(string name);

        IButtonElement WithValue(string value);

        IButtonElement WithType(ButtonType type);
    }
}
