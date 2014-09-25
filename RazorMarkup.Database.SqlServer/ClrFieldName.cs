namespace RazorMarkup.Database.SqlServer
{
    public sealed class ClrFieldName : SqlString
    {
        public ClrFieldName(string fieldName)
            : base(fieldName)
        {
        }
    }
}
