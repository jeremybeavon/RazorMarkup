namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexWithDataCompression : IHideObjectMethods
    {
        ICreateIndexWithDataCompressionOnPartitions None();

        ICreateIndexWithDataCompressionOnPartitions Row();

        ICreateIndexWithDataCompressionOnPartitions Page();
    }
}
