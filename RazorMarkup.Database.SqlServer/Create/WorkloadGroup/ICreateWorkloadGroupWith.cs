namespace RazorMarkup.Database.SqlServer.Create.WorkloadGroup
{
    public interface ICreateWorkloadGroupWith : ICreateWorkloadGroupUsing
    {
        ICreateWorkloadGroupWithImportance Importance();

        ICreateWorkloadGroupWithAnd RequestMaxMemoryGrantPercent(int value);

        ICreateWorkloadGroupWithAnd RequestMaxCpuTimeSec(int value);

        ICreateWorkloadGroupWithAnd RequestMemoryGrantTimeoutSec(int value);

        ICreateWorkloadGroupWithAnd MaxDop(int value);

        ICreateWorkloadGroupWithAnd GroupMaxRequests(int value);
    }
}
