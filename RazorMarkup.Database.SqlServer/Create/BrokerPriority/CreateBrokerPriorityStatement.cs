﻿namespace RazorMarkup.Database.SqlServer.Create.BrokerPriority
{
    internal sealed class CreateBrokerPriorityStatement : AbstractStatement<CreateBrokerPriorityStatementBuilder>,
        ICreateBrokerPriorityStatement
    {
        public CreateBrokerPriorityStatement(ConversationPriorityName name)
            : base(new CreateBrokerPriorityStatementBuilder(name))
        {
            Statement.Initialize(() => Sql.Create().BrokerPriority(null), name);
        }

        public ICreateBrokerPriorityForConversation ForConversation()
        {
            Statement.Append((ICreateBrokerPriorityStatement input) => input.ForConversation());
            return new CreateBrokerPriorityForConversation(Statement);
        }
    }
}
