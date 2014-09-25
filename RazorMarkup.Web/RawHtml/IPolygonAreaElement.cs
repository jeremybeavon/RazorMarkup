using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IPolygonAreaElement : IAreaElement<IPolygonAreaElement>
    {
        /// <summary>
        /// Specifies the coordinates of the edges of the polygon. If the first and last coordinate pairs
        /// are not the same, the browser will add the last coordinate pair to close the polygon
        /// </summary>
        /// <param name="coordinates">Specifies the coordinates of the edges of the polygon.
        /// If the first and last coordinate pairs are not the same, the browser will add the last
        /// coordinate pair to close the polygon</param>
        IPolygonAreaElement WithCoordinates(params int[] coordinates);
    }
}
