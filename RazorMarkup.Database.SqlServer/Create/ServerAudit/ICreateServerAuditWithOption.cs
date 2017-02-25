using System;

namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditWithOption : IHideObjectMethods
    {
        ICreateServerAuditWithAnd QueueDelay(int queueDelay);

        ICreateServerAuditWithOnFailure OnFailure();

        ICreateServerAuditWithAnd AuditGuid(Guid auditGuid);
    }
}
