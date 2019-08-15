namespace RazorMarkup.Web.RawHtml
{
    public interface IMediaOperator : IFluentHtmlString
    {
        /// <summary>
        /// Specifies an AND operator
        /// </summary>
        IMedia And();

        /// <summary>
        /// Specifies an OR operator
        /// </summary>
        IMedia Or();
    }
}
