using System;

namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    internal sealed class CreateEventNotificationToService : AbstractStatement<CreateEventNotificationStatementBuilder>,
        ICreateEventNotificationToService
    {
        public CreateEventNotificationToService(CreateEventNotificationStatementBuilder statement)
            : base(statement)
        {
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
