namespace RazorMarkup.Database.SqlServer
{
    public sealed class DatabaseName : SqlString
    {
        public DatabaseName(string databaseName)
            : base(databaseName)
        {
        }
    }
}
