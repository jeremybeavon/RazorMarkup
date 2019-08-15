namespace RazorMarkup.Web.RawHtml
{
    public interface ICircleAreaElement : IAreaElement<ICircleAreaElement>
    {
        ICircleAreaElement WithCoordinates(int centerX, int centerY, int radius);
    }
}
