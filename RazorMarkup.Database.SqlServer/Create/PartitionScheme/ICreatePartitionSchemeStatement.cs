namespace RazorMarkup.Database.SqlServer.Create.PartitionScheme
{
    public interface ICreatePartitionSchemeStatement : IHideObjectMethods
    {
        ICreatePartitionSchemeAll AsPartition(PartitionFunctionName partitionFunctionName);
    }
}
