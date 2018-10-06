namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexWithDataCompressionOnPartitionsTo : ICreateIndexWithDataCompressionOnPartitionsAnd
    {
        ICreateIndexWithDataCompressionOnPartitionsAnd To(int partitionNumber);
    }
}
