namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateRoleStatement : ISqlString
    {
        ISqlString Authorization(string ownerName);
    }
}
