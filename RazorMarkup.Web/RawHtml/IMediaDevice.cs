namespace RazorMarkup.Web.RawHtml
{
    public interface IMediaDevice : IHideObjectMethods
    {
        /// <summary>
        /// Suitable for all devices
        /// </summary>
        IMediaOperator All();

        /// <summary>
        /// Speech synthesizers
        /// </summary>
        IMediaOperator Aural();

        /// <summary>
        /// Braille feedback devices
        /// </summary>
        IMediaOperator Braille();

        /// <summary>
        /// Handheld devices (small screen, limited bandwidth)
        /// </summary>
        IMediaOperator Handheld();

        /// <summary>
        /// Projectors
        /// </summary>
        IMediaOperator Projector();

        /// <summary>
        /// Print preview mode/printed pages
        /// </summary>
        IMediaOperator Printer();

        /// <summary>
        /// Computer screens
        /// </summary>
        IMediaOperator Screen();

        /// <summary>
        /// Teletypes and similar media using a fixed-pitch character grid
        /// </summary>
        IMediaOperator Teletype();

        /// <summary>
        /// Television type devices (low resolution, limited scroll ability)
        /// </summary>
        IMediaOperator TV();
    }
}
