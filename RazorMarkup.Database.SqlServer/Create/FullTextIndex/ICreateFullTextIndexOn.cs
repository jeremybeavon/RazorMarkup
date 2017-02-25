namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexOn : ICreateFullTextIndexWith
    {
        ICreateFullTextIndexWith On(FullTextCatalogName fullTextCatalogName);

        ICreateFullTextIndexWith On(FullTextCatalogName fullTextCatalogName, FileGroupName fileGroupName);

        ICreateFullTextIndexWith On(FileGroupName fileGroupName, FullTextCatalogName fullTextCatalogName);

        ICreateFullTextIndexWith On(FileGroupName fileGroupName);
    }
}
