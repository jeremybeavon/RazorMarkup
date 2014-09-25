namespace RazorMarkup.Database.SqlServer
{
    public sealed class ClrColumnName : SqlString
    {
        public ClrColumnName(string columnName)
            : base(columnName)
        {
        }
    }
}
