using System;
using System.ComponentModel;
using System.Web;

namespace RazorMarkup.Web
{
    public interface IFluentHtmlString : IHtmlString
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        Type GetType();

        [EditorBrowsable(EditorBrowsableState.Never)]
        int GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        bool Equals(object obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        string ToString();
    }
}
