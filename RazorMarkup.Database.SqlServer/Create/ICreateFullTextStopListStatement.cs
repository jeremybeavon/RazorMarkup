namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateFullTextStopListStatement : ICreateFullTextStopListAuthorization
    {
        ICreateFullTextStopListAuthorization From(DatabaseName databaseName, FullTextStopListName sourceStopListName);

        ICreateFullTextStopListAuthorization From(FullTextStopListName sourceStopListName);

        ICreateFullTextStopListAuthorization FromSystemStopList();
    }
}
