namespace RazorMarkup.Database.SqlServer
{
    public sealed class ClrPropertyName : SqlString
    {
        public ClrPropertyName(string propertyName)
            : base(propertyName)
        {
        }
    }
}
