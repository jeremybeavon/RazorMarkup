namespace RazorMarkup.Database.SqlServer.Create.FullTextCatalog
{
    public interface ICreateFullTextCatalogStatement : ICreateFullTextCatalogInPath
    {
        ICreateFullTextCatalogInPath OnFileGroup(FileGroupName fileGroupName);
    }
}
