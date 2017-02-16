namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    public interface IAlterBrokerPrioritySet : IHideObjectMethods
    {
        IAlterBrokerPrioritySetAnd ContractName(ContractName contractName);

        IAlterBrokerPrioritySetAny ContractName();

        IAlterBrokerPrioritySetAnd LocalServiceName(string localServiceName);

        IAlterBrokerPrioritySetAny LocalServiceName();

        IAlterBrokerPrioritySetAnd RemoteServiceName(string remoteServiceName);

        IAlterBrokerPrioritySetAny RemoteServiceName();

        IAlterBrokerPrioritySetPriorityLevel PriorityLevel();
    }
}
