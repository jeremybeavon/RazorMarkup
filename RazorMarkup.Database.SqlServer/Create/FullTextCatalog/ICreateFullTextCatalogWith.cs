namespace RazorMarkup.Database.SqlServer.Create.FullTextCatalog
{
    public interface ICreateFullTextCatalogWith : ICreateFullTextCatalogAsDefault
    {
        ICreateFullTextCatalogWithAccentSensitivity With();
    }
}
