namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateSearchPropertyListStatement : ICreateSearchPropertyListAuthorization
    {
        ICreateSearchPropertyListAuthorization From(DatabaseName databaseName, string sourceListName);

        ICreateSearchPropertyListAuthorization From(string sourceListName);
    }
}
