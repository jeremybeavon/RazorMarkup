namespace RazorMarkup.Web.RawHtml
{
    internal sealed class MediaOperator : IMediaOperator
    {
        private readonly Media media;

        public MediaOperator(Media media)
        {
            this.media = media;
        }

        public IMedia And()
        {
            media.AppendText(" and ");
            return media;
        }

        public IMedia Or()
        {
            media.AppendText(", ");
            return media;
        }

        public string ToHtmlString()
        {
            return media.ToHtmlString();
        }
    }
}
