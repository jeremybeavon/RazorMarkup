namespace RazorMarkup.Database.SqlServer.Create.WorkloadGroup
{
    public interface ICreateWorkloadGroupUsingDefault : IHideObjectMethods
    {
        ISqlString Default();
    }
}
