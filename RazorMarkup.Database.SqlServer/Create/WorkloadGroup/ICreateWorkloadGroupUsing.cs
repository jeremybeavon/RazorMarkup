namespace RazorMarkup.Database.SqlServer.Create.WorkloadGroup
{
    public interface ICreateWorkloadGroupUsing : ISqlString
    {
        ISqlString Using(ResourcePoolName poolName);

        ICreateWorkloadGroupUsingDefault Using();
    }
}
