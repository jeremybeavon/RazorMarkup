namespace RazorMarkup.Database.SqlServer
{
    public sealed class ServerAuditSpecificationName : SqlString
    {
        public ServerAuditSpecificationName(string serverAuditSpecificationName)
            : base(serverAuditSpecificationName)
        {
        }
    }
}
