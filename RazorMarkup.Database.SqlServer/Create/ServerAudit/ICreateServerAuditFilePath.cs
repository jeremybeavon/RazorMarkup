namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditFilePath : IHideObjectMethods
    {
        ICreateServerAuditFileAnd FilePath(string filePath);
    }
}
