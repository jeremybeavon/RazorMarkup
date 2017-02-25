namespace RazorMarkup.Database.SqlServer.Create.Login
{
    public interface ICreateLoginWithPasswordHashed : ICreateLoginWithPasswordMustChange
    {
        ICreateLoginWithPasswordMustChange Hashed();
    }
}
