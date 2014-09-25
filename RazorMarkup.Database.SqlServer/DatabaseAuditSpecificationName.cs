namespace RazorMarkup.Database.SqlServer
{
    public sealed class DatabaseAuditSpecificationName : SqlString
    {
        public DatabaseAuditSpecificationName(string databaseAuditSpecificationName)
            : base(databaseAuditSpecificationName)
        {
        }
    }
}
