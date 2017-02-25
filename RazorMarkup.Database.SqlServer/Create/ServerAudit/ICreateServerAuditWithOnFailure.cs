namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditWithOnFailure : IHideObjectMethods
    {
        ICreateServerAuditWithAnd Continue();

        ICreateServerAuditWithAnd Shutdown();

        ICreateServerAuditWithAnd FailOperation();
    }
}
