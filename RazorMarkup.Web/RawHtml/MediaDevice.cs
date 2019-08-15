namespace RazorMarkup.Web.RawHtml
{
    internal sealed class MediaDevice : IMediaDevice
    {
        private readonly Media media;

        public MediaDevice(Media media)
        {
            this.media = media;
        }

        public IMediaOperator All()
        {
            media.AppendText("all");
            return new MediaOperator(media);
        }

        public IMediaOperator Aural()
        {
            media.AppendText("aural");
            return new MediaOperator(media);
        }

        public IMediaOperator Braille()
        {
            media.AppendText("braille");
            return new MediaOperator(media);
        }

        public IMediaOperator Handheld()
        {
            media.AppendText("handheld");
            return new MediaOperator(media);
        }

        public IMediaOperator Projector()
        {
            media.AppendText("projection");
            return new MediaOperator(media);
        }

        public IMediaOperator Printer()
        {
            media.AppendText("print");
            return new MediaOperator(media);
        }

        public IMediaOperator Screen()
        {
            media.AppendText("screen");
            return new MediaOperator(media);
        }

        public IMediaOperator Teletype()
        {
            media.AppendText("tty");
            return new MediaOperator(media);
        }

        public IMediaOperator TV()
        {
            media.AppendText("tv");
            return new MediaOperator(media);
        }
    }
}
