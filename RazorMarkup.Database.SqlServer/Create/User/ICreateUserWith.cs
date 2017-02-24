namespace RazorMarkup.Database.SqlServer.Create.User
{
    public interface ICreateUserWith : ISqlString
    {
        ICreateUserWithOption With();
    }
}
