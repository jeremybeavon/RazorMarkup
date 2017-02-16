namespace RazorMarkup.Database.SqlServer.Create.BrokerPriority
{
    public interface ICreateBrokerPrioritySet : IHideObjectMethods
    {
        ICreateBrokerPrioritySetAnd ContractName(ContractName contractName);

        ICreateBrokerPrioritySetAny ContractName();

        ICreateBrokerPrioritySetAnd LocalServiceName(string localServiceName);

        ICreateBrokerPrioritySetAny LocalServiceName();

        ICreateBrokerPrioritySetAnd RemoteServiceName(string remoteServiceName);

        ICreateBrokerPrioritySetAny RemoteServiceName();

        ICreateBrokerPrioritySetPriorityLevel PriorityLevel();
    }
}
