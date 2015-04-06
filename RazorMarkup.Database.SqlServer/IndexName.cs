namespace RazorMarkup.Database.SqlServer
{
    public sealed class IndexName : SqlString
    {
        public IndexName(string indexName)
            : base(indexName)
        {
        }
    }
}
