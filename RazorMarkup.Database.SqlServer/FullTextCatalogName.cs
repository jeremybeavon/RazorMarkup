namespace RazorMarkup.Database.SqlServer
{
    public sealed class FullTextCatalogName : SqlString
    {
        public FullTextCatalogName(string fullTextCatalogName)
            : base(fullTextCatalogName)
        {
        }
    }
}
