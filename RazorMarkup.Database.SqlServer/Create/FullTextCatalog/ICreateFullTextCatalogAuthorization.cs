namespace RazorMarkup.Database.SqlServer.Create.FullTextCatalog
{
    public interface ICreateFullTextCatalogAuthorization : ISqlString
    {
        ISqlString Authorization(string ownerName);
    }
}
