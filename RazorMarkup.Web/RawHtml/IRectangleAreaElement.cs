namespace RazorMarkup.Web.RawHtml
{
    public interface IRectangleAreaElement : IAreaElement<IRectangleAreaElement>
    {
        IRectangleAreaElement WithCoordinates(int left, int top, int right, int bottom);
    }
}
