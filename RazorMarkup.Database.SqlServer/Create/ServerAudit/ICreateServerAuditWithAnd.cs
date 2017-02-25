namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditWithAnd : ICreateServerAuditWhere
    {
        ICreateServerAuditWithOption And();
    }
}
