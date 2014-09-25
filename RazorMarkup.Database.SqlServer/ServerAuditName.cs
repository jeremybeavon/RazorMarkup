namespace RazorMarkup.Database.SqlServer
{
    public sealed class ServerAuditName : SqlString
    {
        public ServerAuditName(string serverAuditName)
            : base(serverAuditName)
        {
        }
    }
}
