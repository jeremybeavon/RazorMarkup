﻿namespace RazorMarkup.Web.RawHtml
{
    internal sealed class RectangleAreaElement : AbstractAreaElement<IRectangleAreaElement>, IRectangleAreaElement
    {
        public RectangleAreaElement()
            : base("rect")
        {
        }

        public IRectangleAreaElement WithCoordinates(int left, int top, int right, int bottom)
        {
            return AddAttribute("coords", string.Join(",", left, top, right, bottom));
        }
    }
}
