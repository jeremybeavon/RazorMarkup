namespace RazorMarkup.Database.SqlServer.Create.FullTextCatalog
{
    public interface ICreateFullTextCatalogInPath : ICreateFullTextCatalogWith
    {
        ICreateFullTextCatalogWith InPath(string rootPath);
    }
}
