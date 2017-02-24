namespace RazorMarkup.Database.SqlServer.Create.User
{
    public interface ICreateUserStatement : ICreateUserWith
    {
        ICreateUserForOrFromOption For();

        ICreateUserForOrFromOption From();

        ICreateUserWithDefaultSchema WithoutLogin();
    }
}
