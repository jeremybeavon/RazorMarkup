namespace RazorMarkup.Web.RawHtml
{
    internal sealed class FieldsetElement : AbstractHtmlElement<IFieldsetElement>, IFieldsetElement
    {
        public FieldsetElement()
            : base("fieldset", false)
        {
        }
    }
}
