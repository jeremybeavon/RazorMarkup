namespace RazorMarkup.Database.SqlServer
{
    public sealed class CollationName : SqlString
    {
        public CollationName(string collationName)
            : base(collationName)
        {
        }
    }
}
