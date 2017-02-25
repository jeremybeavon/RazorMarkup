namespace RazorMarkup.Database.SqlServer.Create.Login
{
    public interface ICreateLoginFromWindowsWithOption : IHideObjectMethods
    {
        ICreateLoginFromWindowsWithAnd DefaultDatabase(DatabaseName databaseName);

        ICreateLoginFromWindowsWithAnd DefaultLanguage(string language);
    }
}
