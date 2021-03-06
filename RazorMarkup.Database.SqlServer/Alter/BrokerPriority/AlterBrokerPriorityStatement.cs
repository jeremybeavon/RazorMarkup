﻿namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    internal sealed class AlterBrokerPriorityStatement : AbstractStatement<AlterBrokerPriorityStatementBuilder>,
        IAlterBrokerPriorityStatement
    {
        public AlterBrokerPriorityStatement(ConversationPriorityName name)
            : base(new AlterBrokerPriorityStatementBuilder(name))
        {
            Statement.Initialize(() => Sql.Alter().BrokerPriority(null), name);
        }

        public IAlterBrokerPriorityForConversation ForConversation()
        {
            Statement.Append((IAlterBrokerPriorityStatement input) => input.ForConversation());
            return new AlterBrokerPriorityForConversation(Statement);
        }
    }
}
