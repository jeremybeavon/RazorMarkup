namespace RazorMarkup.Database.SqlServer.Create.Service
{
    public interface ICreateServiceOnQueue : IHideObjectMethods
    {
        ICreateServiceOnQueueDefault OnQueue(SchemaName schemaName, QueueName queueName);

        ICreateServiceOnQueueDefault OnQueue(QueueName queueName);

        ICreateServiceOnQueueAnd OnQueue(SchemaName schemaName, QueueName queueName, ContractName contractName);

        ICreateServiceOnQueueAnd OnQueue(QueueName queueName, ContractName contractName);
    }
}
