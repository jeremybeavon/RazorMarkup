namespace RazorMarkup.Database.SqlServer.Create.ServerAuditSpecification
{
    public interface ICreateServerAuditSpecificationAdd : IHideObjectMethods
    {
        ICreateServerAuditSpecificationAddAnd Add(string auditActionGroupName);
    }
}
