namespace RazorMarkup.Database.SqlServer.Create.FullTextCatalog
{
    public interface ICreateFullTextCatalogAsDefault : ICreateFullTextCatalogAuthorization
    {
        ICreateFullTextCatalogAuthorization AsDefault();
    }
}
