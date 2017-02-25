namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditFileOnOff : IHideObjectMethods
    {
        ICreateServerAuditFileAnd On();

        ICreateServerAuditFileAnd Off();
    }
}
