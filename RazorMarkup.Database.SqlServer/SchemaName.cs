namespace RazorMarkup.Database.SqlServer
{
    public sealed class SchemaName : SqlString
    {
        public SchemaName(string schemaName)
            : base(schemaName)
        {
        }
    }
}
