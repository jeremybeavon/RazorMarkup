﻿namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    internal sealed class AlterBrokerPrioritySetAnd : AbstractStatement<AlterBrokerPriorityStatementBuilder>,
        IAlterBrokerPrioritySetAnd
    {
        public AlterBrokerPrioritySetAnd(AlterBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public IAlterBrokerPrioritySet And()
        {
            Statement.Append((IAlterBrokerPrioritySetAnd input) => input.And());
            return new AlterBrokerPrioritySet(Statement);
        }
    }
}
