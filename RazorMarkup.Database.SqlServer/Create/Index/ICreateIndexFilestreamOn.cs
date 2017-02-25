namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexFilestreamOn : ISqlString
    {
        ISqlString FilestreamOn(FileGroupName fileGroupName);

        ISqlString FilestreamOn(PartitionSchemeName partitionSchemeName);

        ICreateIndexFilestreamOnNull FilestreamOn();
    }
}
