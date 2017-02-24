namespace RazorMarkup.Database.SqlServer.Create.User
{
    public interface ICreateUserWithAnd : ISqlString
    {
        ICreateUserWithOption And();
    }
}
