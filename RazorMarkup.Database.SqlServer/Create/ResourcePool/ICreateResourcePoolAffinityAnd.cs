namespace RazorMarkup.Database.SqlServer.Create.ResourcePool
{
    public interface ICreateResourcePoolAffinityAnd : ICreateResourcePoolWithAnd
    {
        ICreateResourcePoolAffinityTo And(int id);
    }
}
