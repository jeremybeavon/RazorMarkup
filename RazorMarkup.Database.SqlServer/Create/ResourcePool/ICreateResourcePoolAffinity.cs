namespace RazorMarkup.Database.SqlServer.Create.ResourcePool
{
    public interface ICreateResourcePoolAffinity : IHideObjectMethods
    {
        ICreateResourcePoolAffinitySchedulerAuto Scheduler();

        ICreateResourcePoolAffinityTo Scheduler(int schedulerId);

        ICreateResourcePoolAffinityTo NumaNode(int numaNodeId);
    }
}
