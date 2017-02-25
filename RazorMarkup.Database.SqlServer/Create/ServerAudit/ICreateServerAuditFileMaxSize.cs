namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditFileMaxSize : IHideObjectMethods
    {
        ICreateServerAuditFileAnd MB();

        ICreateServerAuditFileAnd GB();

        ICreateServerAuditFileAnd TB();
    }
}
