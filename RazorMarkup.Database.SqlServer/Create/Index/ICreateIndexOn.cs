namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexOn : ICreateIndexFilestreamOn
    {
        ICreateIndexFilestreamOn On(PartitionSchemeName partitionSchemeName, ColumnName columnName);

        ICreateIndexFilestreamOn On(FileGroupName fileGroupName);

        ICreateIndexFilestreamOn OnDefault();
    }
}
