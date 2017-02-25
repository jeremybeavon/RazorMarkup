namespace RazorMarkup.Database.SqlServer.Create.ResourcePool
{
    public interface ICreateResourcePoolAffinityTo : ICreateResourcePoolAffinityAnd
    {
        ICreateResourcePoolAffinityAnd To(int id);
    }
}
