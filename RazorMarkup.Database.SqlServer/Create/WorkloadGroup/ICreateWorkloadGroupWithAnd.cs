namespace RazorMarkup.Database.SqlServer.Create.WorkloadGroup
{
    public interface ICreateWorkloadGroupWithAnd : ICreateWorkloadGroupUsing
    {
        ICreateWorkloadGroupWith And();
    }
}
