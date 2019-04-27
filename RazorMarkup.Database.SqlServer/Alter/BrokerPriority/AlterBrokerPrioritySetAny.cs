namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    internal sealed class AlterBrokerPrioritySetAny : AbstractStatement<AlterBrokerPriorityStatementBuilder>,
        IAlterBrokerPrioritySetAny
    {
        public AlterBrokerPrioritySetAny(AlterBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public IAlterBrokerPrioritySetAnd Any()
        {
            Statement.Append((IAlterBrokerPrioritySetAny input) => input.Any());
            return new AlterBrokerPrioritySetAnd(Statement);
        }
    }
}
