namespace RazorMarkup.Database.SqlServer.Create.PartitionScheme
{
    public interface ICreatePartitionSchemeToAnd : ISqlString
    {
        ICreatePartitionSchemeToAnd And(FileGroupName fileGroupName);

        ICreatePartitionSchemeToAnd AndPrimary();
    }
}
