namespace RazorMarkup.Database.SqlServer
{
    public sealed class ColumnName : SqlString
    {
        public ColumnName(string columnName)
            : base(columnName)
        {
        }
    }
}
