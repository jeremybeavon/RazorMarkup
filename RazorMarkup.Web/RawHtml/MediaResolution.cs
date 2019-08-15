namespace RazorMarkup.Web.RawHtml
{
    internal sealed class MediaResolution : IMediaResolution
    {
        private readonly Media media;

        public MediaResolution(Media media)
        {
            this.media = media;
        }

        public IMediaOperator AsDotsPerInch(int resolution)
        {
            media.AppendText(string.Format("(resolution:{0}dpi)", resolution));
            return new MediaOperator(media);
        }

        public IMediaOperator AsDotsPerCentimeter(int resolution)
        {
            media.AppendText(string.Format("(resolution:{0}dpcm)", resolution));
            return new MediaOperator(media);
        }
    }
}
