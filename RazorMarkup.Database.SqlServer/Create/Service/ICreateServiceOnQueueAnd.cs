namespace RazorMarkup.Database.SqlServer.Create.Service
{
    public interface ICreateServiceOnQueueAnd : ISqlString
    {
        ICreateServiceOnQueueAnd And(ContractName contractName);

        ICreateServiceOnQueueAndDefault And();
    }
}
