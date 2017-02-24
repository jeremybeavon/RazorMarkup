using RazorMarkup.Database.SqlServer.Create.Trigger.AllServer;
using RazorMarkup.Database.SqlServer.Create.Trigger.Database;

namespace RazorMarkup.Database.SqlServer.Create.Trigger
{
    public interface ICreateTriggerStatementWithDdl : ICreateTriggerStatement
    {
        ICreateTriggerAllServerWith OnAllServer();

        ICreateTriggerDatabaseWith OnDatabase();
    }
}
