using System;

namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    internal sealed class CreateEventNotificationStatement : AbstractStatement<CreateEventNotificationStatementBuilder>,
        ICreateEventNotificationToService
    {
        public CreateEventNotificationStatement(EventNotificationName eventNotificationName)
            : base(new CreateEventNotificationStatementBuilder(eventNotificationName))
        {
            Statement.Initialize(() => Sql.Create().EventNotification(null), eventNotificationName);
        }

        public ISqlString ToService(string brokerService, CurrentDatabaseOption currentDatabase)
        {
            Statement.BrokerService = brokerService;
            Statement.BrokerInstanceSpecifier = "current database";
            Statement.Append(
                (ICreateEventNotificationToService input) => input.ToService(null, CurrentDatabaseOption.CurrentDatabase),
                new RawStatementBuilder(brokerService),
                RawStatementBuilder.Constant(CurrentDatabaseOption.CurrentDatabase));
            return this;
        }

        public ISqlString ToService(string brokerService, string brokerInstanceSpecifier)
        {
            Statement.BrokerService = brokerService;
            Statement.BrokerInstanceSpecifier = brokerInstanceSpecifier;
            Statement.Append(
                (ICreateEventNotificationToService input) => input.ToService(null, null),
                new RawStatementBuilder(brokerService),
                new RawStatementBuilder(brokerInstanceSpecifier));
            return this;
        }
    }
}
