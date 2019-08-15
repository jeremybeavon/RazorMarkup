namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class ImageElementExtensions
    {
        public static IFigureElements Figure(this IImageElement image)
        {
            return new FigureElements();
        }
    }
}
