namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    internal sealed class AlterBrokerPrioritySetPriorityLevel : AbstractStatement<AlterBrokerPriorityStatementBuilder>,
        IAlterBrokerPrioritySetPriorityLevel
    {
        public AlterBrokerPrioritySetPriorityLevel(AlterBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public IAlterBrokerPrioritySetAnd Default()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Default());
            Statement.PriorityLevel = "DEFAULT";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd Eight()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Eight());
            Statement.PriorityLevel = "8";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd Five()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Five());
            Statement.PriorityLevel = "5";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd Four()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Four());
            Statement.PriorityLevel = "4";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd Nine()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Nine());
            Statement.PriorityLevel = "9";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd One()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.One());
            Statement.PriorityLevel = "1";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd Seven()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Seven());
            Statement.PriorityLevel = "7";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd Six()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Six());
            Statement.PriorityLevel = "6";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd Ten()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Ten());
            Statement.PriorityLevel = "10";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd Three()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Three());
            Statement.PriorityLevel = "3";
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAnd Two()
        {
            Statement.Append((IAlterBrokerPrioritySetPriorityLevel input) => input.Two());
            Statement.PriorityLevel = "2";
            return new AlterBrokerPrioritySetAnd(Statement);
        }
    }
}
