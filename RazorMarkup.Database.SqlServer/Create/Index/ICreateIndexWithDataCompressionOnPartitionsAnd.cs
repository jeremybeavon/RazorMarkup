namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexWithDataCompressionOnPartitionsAnd : ICreateIndexWithAnd
    {
        ICreateIndexWithDataCompressionOnPartitionsTo And(int partitionNumber);
    }
}
