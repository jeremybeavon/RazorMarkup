namespace RazorMarkup.Database.SqlServer.Create.BrokerPriority
{
    internal sealed class CreateBrokerPrioritySetPriorityLevel : AbstractStatement<CreateBrokerPriorityStatementBuilder>,
        ICreateBrokerPrioritySetPriorityLevel
    {
        public CreateBrokerPrioritySetPriorityLevel(CreateBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public ICreateBrokerPrioritySetAnd Default()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Default());
            Statement.PriorityLevel = "DEFAULT";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd Eight()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Eight());
            Statement.PriorityLevel = "8";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd Five()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Five());
            Statement.PriorityLevel = "5";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd Four()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Four());
            Statement.PriorityLevel = "4";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd Nine()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Nine());
            Statement.PriorityLevel = "9";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd One()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.One());
            Statement.PriorityLevel = "1";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd Seven()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Seven());
            Statement.PriorityLevel = "7";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd Six()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Six());
            Statement.PriorityLevel = "6";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd Ten()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Ten());
            Statement.PriorityLevel = "10";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd Three()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Three());
            Statement.PriorityLevel = "3";
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAnd Two()
        {
            Statement.Append((ICreateBrokerPrioritySetPriorityLevel input) => input.Two());
            Statement.PriorityLevel = "2";
            return new CreateBrokerPrioritySetAnd(Statement);
        }
    }
}
