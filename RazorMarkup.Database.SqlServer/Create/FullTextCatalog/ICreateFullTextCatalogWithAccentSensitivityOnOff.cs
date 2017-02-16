namespace RazorMarkup.Database.SqlServer.Create.FullTextCatalog
{
    public interface ICreateFullTextCatalogWithAccentSensitivityOnOff : IHideObjectMethods
    {
        ICreateFullTextCatalogAsDefault On();

        ICreateFullTextCatalogAsDefault Off();
    }
}
