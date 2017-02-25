namespace RazorMarkup.Database.SqlServer.Create.ServerAuditSpecification
{
    public interface ICreateServerAuditSpecificationWithOption : IHideObjectMethods
    {
        ICreateServerAuditSpecificationWithOptionOnOff State();
    }
}
