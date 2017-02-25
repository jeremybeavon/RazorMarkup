namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexWithDataCompressionOnPartitions : ICreateIndexWithAnd
    {
        ICreateIndexWithDataCompressionOnPartitionsTo OnPartitions(int partitionNumber);
    }
}
