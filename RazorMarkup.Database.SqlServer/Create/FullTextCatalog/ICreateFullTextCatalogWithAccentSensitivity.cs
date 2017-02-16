namespace RazorMarkup.Database.SqlServer.Create.FullTextCatalog
{
    public interface ICreateFullTextCatalogWithAccentSensitivity : IHideObjectMethods
    {
        ICreateFullTextCatalogWithAccentSensitivityOnOff AccentSensitivity();
    }
}
