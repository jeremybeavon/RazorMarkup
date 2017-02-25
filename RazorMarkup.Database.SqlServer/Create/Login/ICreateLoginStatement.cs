namespace RazorMarkup.Database.SqlServer.Create.Login
{
    public interface ICreateLoginStatement : IHideObjectMethods
    {
        ICreateLoginWithPasswordHashed WithPassword(string password);

        ICreateLoginFrom From();
    }
}
