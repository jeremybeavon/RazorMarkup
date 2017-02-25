namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditFileAnd : ISqlString
    {
        ICreateServerAuditFileOption And();
    }
}
