namespace RazorMarkup.Database.SqlServer
{
    public sealed class PartitionFunctionName : SqlString
    {
        public PartitionFunctionName(string partitionFunctionName)
            : base(partitionFunctionName)
        {
        }
    }
}
