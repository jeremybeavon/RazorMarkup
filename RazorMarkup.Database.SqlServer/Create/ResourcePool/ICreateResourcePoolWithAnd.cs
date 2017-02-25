namespace RazorMarkup.Database.SqlServer.Create.ResourcePool
{
    public interface ICreateResourcePoolWithAnd : ISqlString
    {
        ICreateResourcePoolWithOption And();
    }
}
