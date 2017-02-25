namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateSearchPropertyListAuthorization : ISqlString
    {
        ISqlString Authorization(string ownerName);
    }
}
