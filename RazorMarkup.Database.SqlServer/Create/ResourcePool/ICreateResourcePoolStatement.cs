namespace RazorMarkup.Database.SqlServer.Create.ResourcePool
{
    public interface ICreateResourcePoolStatement : ISqlString
    {
        ICreateResourcePoolWithOption With();
    }
}
