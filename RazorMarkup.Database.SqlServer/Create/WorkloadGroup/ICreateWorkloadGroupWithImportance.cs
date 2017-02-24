namespace RazorMarkup.Database.SqlServer.Create.WorkloadGroup
{
    public interface ICreateWorkloadGroupWithImportance : IHideObjectMethods
    {
        ICreateWorkloadGroupWithAnd Low();

        ICreateWorkloadGroupWithAnd Medium();

        ICreateWorkloadGroupWithAnd High();
    }
}
