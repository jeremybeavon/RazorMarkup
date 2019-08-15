using System;

namespace RazorMarkup.Web.AngularJs
{
    internal static class DateTimeExtensions
    {
        public static string ToHtmlString(this DateTime date)
        {
            return date.ToString("yyyy-MM-ddTHH:mm:ss");
        }
    }
}
