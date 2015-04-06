namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropEventNotificationStatement : SqlBuilder, IDropEventNotificationStatement
    {
        public DropEventNotificationStatement(EventNotificationName eventNotificationName)
            : base(string.Format("DROP EVENT NOTIFICATION {0}", eventNotificationName.ToSqlString()))
        {
            Initialize(() => Sql.Drop().EventNotification(null), eventNotificationName);
        }

        public IDropEventNotificationStatement And(EventNotificationName eventNotificationName)
        {
            Append(", ");
            Append(eventNotificationName.ToSqlString());
            Append((IDropEventNotificationStatement input) => input.And(null), eventNotificationName);
            return this;
        }

        public ISqlString OnDatabase()
        {
            Append(" ON DATABASE");
            Append((IDropEventNotificationStatement input) => input.OnDatabase());
            return this;
        }

        public ISqlString OnQueue(QueueName queueName)
        {
            Append(" ON QUEUE ");
            Append(queueName.ToSqlString());
            Append((IDropEventNotificationStatement input) => input.OnQueue(null), queueName);
            return this;
        }

        public ISqlString OnServer()
        {
            Append(" ON SERVER");
            Append((IDropEventNotificationStatement input) => input.OnServer());
            return this;
        }
    }
}
