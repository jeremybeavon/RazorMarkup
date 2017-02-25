namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditStatement : IHideObjectMethods
    {
        ICreateServerAuditTo To();
    }
}
