namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateFullTextStopListAuthorization : ISqlString
    {
        ISqlString Authorization(string ownerName);
    }
}
