namespace RazorMarkup.Web.RawHtml
{
    public interface IInputHiddenElement : IInputElement<IInputHiddenElement>
    {
        IInputHiddenElement WithValue(string value);
    }
}
