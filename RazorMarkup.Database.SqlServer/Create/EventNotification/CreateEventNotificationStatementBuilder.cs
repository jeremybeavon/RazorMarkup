using System.Collections.Generic;

namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    internal sealed class CreateEventNotificationStatementBuilder : AbstractStatementBuilder
    {
        public CreateEventNotificationStatementBuilder(EventNotificationName name)
            : base(new ExpressionBuilder())
        {
            Name = name;
            EventTypesAndGroups = new List<string>();
        }

        public EventNotificationName Name { get; private set; }

        public bool IsServer { get; set; }

        public bool IsDatabase { get; set; }

        public string QueueName { get; set; }

        public bool WithFanIn { get; set; }

        public List<string> EventTypesAndGroups { get; private set; }

        public string BrokerService { get; set; }

        public string BrokerInstanceSpecifier { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("CREATE EVENT NOTIFICATION ");
            sqlBuilder.Append(Name.ToSqlString());
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("ON ");
            if (IsServer)
            {
                sqlBuilder.Append("SERVER");
            }
            else if (IsDatabase)
            {
                sqlBuilder.Append("DATABASE");
            }
            else
            {
                sqlBuilder.Append("QUEUE ");
                sqlBuilder.Append(QueueName);
            }

            sqlBuilder.AppendIndent();
            if (WithFanIn)
            {
                sqlBuilder.Append("WITH FAN IN");
                sqlBuilder.AppendIndent();
            }

            sqlBuilder.Append("FOR ");
            sqlBuilder.Append(string.Join(", ", EventTypesAndGroups));
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("TO SERVICE '");
            sqlBuilder.Append(BrokerService);
            sqlBuilder.Append("', '");
            sqlBuilder.Append(BrokerInstanceSpecifier);
            sqlBuilder.Append("'");
        }
    }
}
