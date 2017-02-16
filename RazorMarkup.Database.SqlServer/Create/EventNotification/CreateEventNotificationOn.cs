using System;

namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    internal sealed class CreateEventNotificationOn : AbstractStatement<CreateEventNotificationStatementBuilder>,
        ICreateEventNotificationOn
    {
        public CreateEventNotificationOn(CreateEventNotificationStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateEventNotificationWithFanIn Database()
        {
            Statement.IsDatabase = true;
            Statement.Append((ICreateEventNotificationOn input) => input.Database());
            return new CreateEventNotificationWithFanIn(Statement);
        }

        public ICreateEventNotificationWithFanIn Queue(QueueName queueName)
        {
            Statement.QueueName = queueName.ToSqlString();
            Statement.Append((ICreateEventNotificationOn input) => input.Queue(null), queueName);
            return new CreateEventNotificationWithFanIn(Statement);
        }

        public ICreateEventNotificationWithFanIn Server()
        {
            Statement.IsServer = true;
            Statement.Append((ICreateEventNotificationOn input) => input.Server());
            return new CreateEventNotificationWithFanIn(Statement);
        }
    }
}
