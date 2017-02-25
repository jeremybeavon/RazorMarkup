namespace RazorMarkup.Database.SqlServer.Create.Login
{
    public interface ICreateLoginWithPasswordMustChange : ICreateLoginWithPasswordAnd
    {
        ICreateLoginWithPasswordAnd MustChange();
    }
}
