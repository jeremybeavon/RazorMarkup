namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateApplicationRoleStatement : IHideObjectMethods
    {
        ICreateApplicationRoleDefaultSchema WithPassword(string password);
    }
}
