namespace RazorMarkup.Database.SqlServer
{
    public sealed class ViewName : SqlString
    {
        public ViewName(string viewName)
            : base(viewName)
        {
        }
    }
}
