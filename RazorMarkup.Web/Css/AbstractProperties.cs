namespace RazorMarkup.Web.Css
{
    internal abstract class AbstractProperties
    {
        protected static string Property(string name, string value)
        {
            return string.Format("{0}: {1};", name, value);
        }
    }
}
