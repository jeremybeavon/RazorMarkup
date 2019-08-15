namespace RazorMarkup.Web.RawHtml
{
    internal sealed class PolygonAreaElement : AbstractAreaElement<IPolygonAreaElement>, IPolygonAreaElement
    {
        public PolygonAreaElement()
            : base("poly")
        {
        }

        public IPolygonAreaElement WithCoordinates(params int[] coordinates)
        {
            return AddAttribute("coords", string.Join(",", coordinates));
        }
    }
}
