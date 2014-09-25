namespace RazorMarkup.Database.SqlServer
{
    public sealed class ColumnAlias : SqlString
    {
        public ColumnAlias(string columnAlias)
            : base(columnAlias)
        {
        }
    }
}
