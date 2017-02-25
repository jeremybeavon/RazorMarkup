namespace RazorMarkup.Database.SqlServer.Create.ServerAuditSpecification
{
    public interface ICreateServerAuditSpecificationStatement : IHideObjectMethods
    {
        object ForServerAudit(ServerAuditName serverAuditName);
    }
}
