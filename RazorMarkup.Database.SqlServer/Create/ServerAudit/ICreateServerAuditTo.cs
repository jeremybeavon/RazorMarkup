namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditTo : IHideObjectMethods
    {
        ICreateServerAuditFilePath File();

        ICreateServerAuditWith ApplicationLog();

        ICreateServerAuditWith SecurityLog();
    }
}
