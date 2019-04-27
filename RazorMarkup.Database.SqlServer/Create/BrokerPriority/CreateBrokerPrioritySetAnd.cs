namespace RazorMarkup.Database.SqlServer.Create.BrokerPriority
{
    internal sealed class CreateBrokerPrioritySetAnd : AbstractStatement<CreateBrokerPriorityStatementBuilder>,
        ICreateBrokerPrioritySetAnd
    {
        public CreateBrokerPrioritySetAnd(CreateBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public ICreateBrokerPrioritySet And()
        {
            Statement.Append((ICreateBrokerPrioritySetAnd input) => input.And());
            return new CreateBrokerPrioritySet(Statement);
        }
    }
}
