namespace RazorMarkup.Web.RawHtml
{
    public interface IMediaResolution : IHideObjectMethods
    {
        /// <summary>
        /// Specifies the pixel density of the target display/paper.
        /// </summary>
        IMediaOperator AsDotsPerInch(int resolution);

        /// <summary>
        /// Specifies the pixel density of the target display/paper.
        /// </summary>
        IMediaOperator AsDotsPerCentimeter(int resolution);
    }
}
