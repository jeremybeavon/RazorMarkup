﻿namespace RazorMarkup.Database.SqlServer.Create.BrokerPriority
{
    internal sealed class CreateBrokerPriorityForConversation : AbstractStatement<CreateBrokerPriorityStatementBuilder>,
        ICreateBrokerPriorityForConversation
    {
        public CreateBrokerPriorityForConversation(CreateBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public ICreateBrokerPrioritySet Set()
        {
            Statement.Append((ICreateBrokerPriorityForConversation input) => input.Set());
            return new CreateBrokerPrioritySet(Statement);
        }
    }
}
