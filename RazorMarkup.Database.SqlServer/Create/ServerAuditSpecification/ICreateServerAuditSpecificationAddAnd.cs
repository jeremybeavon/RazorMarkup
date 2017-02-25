namespace RazorMarkup.Database.SqlServer.Create.ServerAuditSpecification
{
    public interface ICreateServerAuditSpecificationAddAnd : ICreateServerAuditSpecificationWith
    {
        ICreateServerAuditSpecificationAddAnd And(string auditActionGroupName);
    }
}
