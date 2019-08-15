namespace RazorMarkup.Web.RawHtml
{
    public interface IParameterElement : IHtmlElement<IParameterElement>
    {
        IParameterElement WithName(string name);

        IParameterElement WithValue(string value);
    }
}
