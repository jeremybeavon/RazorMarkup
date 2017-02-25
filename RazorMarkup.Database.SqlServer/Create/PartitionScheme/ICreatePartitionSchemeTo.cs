namespace RazorMarkup.Database.SqlServer.Create.PartitionScheme
{
    public interface ICreatePartitionSchemeTo : IHideObjectMethods
    {
        ICreatePartitionSchemeToAnd To(FileGroupName fileGroupName);

        ICreatePartitionSchemeToAnd ToPrimary();
    }
}
