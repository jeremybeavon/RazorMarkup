namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    internal sealed class AlterBrokerPrioritySet : AbstractStatement<AlterBrokerPriorityStatementBuilder>,
        IAlterBrokerPrioritySet
    {
        public AlterBrokerPrioritySet(AlterBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public IAlterBrokerPrioritySetAny ContractName()
        {
            Statement.Append((IAlterBrokerPrioritySet input) => input.ContractName());
            Statement.ContractName = "ANY";
            return new AlterBrokerPrioritySetAny(Statement);
        }

        public IAlterBrokerPrioritySetAnd ContractName(ContractName contractName)
        {
            Statement.Append((IAlterBrokerPrioritySet input) => input.ContractName(null), contractName);
            Statement.ContractName = contractName.ToSqlString();
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetAny LocalServiceName()
        {
            Statement.Append((IAlterBrokerPrioritySet input) => input.LocalServiceName());
            Statement.LocalServiceName = "ANY";
            return new AlterBrokerPrioritySetAny(Statement);
        }

        public IAlterBrokerPrioritySetAnd LocalServiceName(string localServiceName)
        {
            Statement.Append(
                (IAlterBrokerPrioritySet input) => input.LocalServiceName(null),
                new RawStatementBuilder(localServiceName));
            Statement.LocalServiceName = localServiceName;
            return new AlterBrokerPrioritySetAnd(Statement);
        }

        public IAlterBrokerPrioritySetPriorityLevel PriorityLevel()
        {
            Statement.Append((IAlterBrokerPrioritySet input) => input.PriorityLevel());
            return new AlterBrokerPrioritySetPriorityLevel(Statement);
        }

        public IAlterBrokerPrioritySetAny RemoteServiceName()
        {
            Statement.Append((IAlterBrokerPrioritySet input) => input.RemoteServiceName());
            Statement.RemoteServiceName = "ANY";
            return new AlterBrokerPrioritySetAny(Statement);
        }

        public IAlterBrokerPrioritySetAnd RemoteServiceName(string remoteServiceName)
        {
            Statement.Append(
                (IAlterBrokerPrioritySet input) => input.RemoteServiceName(null),
                new RawStatementBuilder(remoteServiceName));
            Statement.RemoteServiceName = $"'{remoteServiceName}'";
            return new AlterBrokerPrioritySetAnd(Statement);
        }
    }
}
