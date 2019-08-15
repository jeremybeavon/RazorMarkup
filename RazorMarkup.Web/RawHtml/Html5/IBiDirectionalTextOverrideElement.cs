namespace RazorMarkup.Web.RawHtml.Html5
{
    public interface IBidirectionalTextOverrideElement : 
        IHtmlElement<IBidirectionalTextOverrideElement>
    {
        IBidirectionalTextOverrideElement WithTextDirection(TextDirectionOverride textDirection);
    }
}
