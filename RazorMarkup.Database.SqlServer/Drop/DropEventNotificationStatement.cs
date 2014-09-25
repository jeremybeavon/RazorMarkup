namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropEventNotificationStatement : SqlBuilder, IDropEventNotificationStatement
    {
        public DropEventNotificationStatement(EventNotificationName eventNotificationName)
            : base(string.Format("DROP EVENT NOTIFICATION {0}", eventNotificationName.ToSqlString()))
        {
        }

        public IDropEventNotificationStatement And(EventNotificationName eventNotificationName)
        {
            Append(", ");
            Append(eventNotificationName.ToSqlString());
            return this;
        }

        public ISqlString OnDatabase()
        {
            Append(" ON DATABASE");
            return this;
        }

        public ISqlString OnQueue(QueueName queueName)
        {
            Append(" ON QUEUE");
            Append(queueName.ToSqlString());
            return this;
        }

        public ISqlString OnServer()
        {
            Append(" ON SERVER");
            return this;
        }
    }
}
