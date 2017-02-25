namespace RazorMarkup.Database.SqlServer.Create.ServerAuditSpecification
{
    public interface ICreateServerAuditSpecificationWithOptionOnOff : IHideObjectMethods
    {
        ISqlString On();

        ISqlString Off();
    }
}
