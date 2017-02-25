namespace RazorMarkup.Database.SqlServer.Create.ResourcePool
{
    public interface ICreateResourcePoolWithOption : IHideObjectMethods
    {
        ICreateResourcePoolWithAnd MinCpuPercent(int minCpuPercent);

        ICreateResourcePoolWithAnd MaxCpuPercent(int maxCpuPercent);

        ICreateResourcePoolWithAnd CapCpuPercent(int capCpuPercent);

        ICreateResourcePoolAffinity Affinity();

        ICreateResourcePoolWithAnd MinMemoryPercent(int minMemoryPercent);

        ICreateResourcePoolWithAnd MaxMemoryPercent(int maxMemoryPercent);
    }
}
