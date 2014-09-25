namespace RazorMarkup.Database.SqlServer
{
    public sealed class PartitionSchemeName : SqlString
    {
        public PartitionSchemeName(string partitionSchemeName)
            : base(partitionSchemeName)
        {
        }
    }
}
