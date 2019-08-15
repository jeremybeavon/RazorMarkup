namespace RazorMarkup.Web.RawHtml
{
    public interface IInputFileElement : IInputElement<IInputFileElement>
    {
        IInputFileElement WithFileExtension(params string[] fileExtensions);

        IInputFileElement WithDisabled();
    }
}
