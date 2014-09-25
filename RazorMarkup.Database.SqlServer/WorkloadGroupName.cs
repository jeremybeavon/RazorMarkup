namespace RazorMarkup.Database.SqlServer
{
    public sealed class WorkloadGroupName : SqlString
    {
        public WorkloadGroupName(string workloadGroupName)
            : base(workloadGroupName)
        {
        }
    }
}
