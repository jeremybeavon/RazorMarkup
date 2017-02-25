using System;

namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditFileOption : IHideObjectMethods
    {
        ICreateServerAuditFileMaxSize MaxSize(int maxSize);

        ICreateServerAuditFileUnlimited MaxSize();

        ICreateServerAuditFileAnd MaxRolloverFiles(int maxRolloverFiles);

        ICreateServerAuditFileUnlimited MaxRolloverFiles();

        ICreateServerAuditFileAnd MaxFiles(int maxFiles);

        ICreateServerAuditFileOnOff ReserveDiskSpace();
    }
}
