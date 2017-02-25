namespace RazorMarkup.Database.SqlServer.Create.Login
{
    public interface ICreateLoginFromWindowsWithAnd : ISqlString
    {
        ICreateLoginFromWindowsWithOption And();
    }
}
