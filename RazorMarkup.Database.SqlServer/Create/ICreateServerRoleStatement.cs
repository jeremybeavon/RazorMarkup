namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateServerRoleStatement : ISqlString
    {
        ISqlString Authorization(string ownerName);
    }
}
