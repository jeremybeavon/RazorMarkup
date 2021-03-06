﻿namespace RazorMarkup.Web.RawHtml
{
    public interface IImageElement : IHtmlElement<IImageElement>
    {
        IImageElement WithAlternateText(string text);

        IImageElement WithHeight(int pixels);

        IImageElement WithUrl(string url);

        IImageElement WithImageMap(string name);

        IImageElement WithWidth(int pixels);
    }
}
