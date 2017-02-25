namespace RazorMarkup.Database.SqlServer.Create.Login
{
    public interface ICreateLoginWithPasswordOptionOnOff : IHideObjectMethods
    {
        ICreateLoginWithPasswordAnd On();

        ICreateLoginWithPasswordAnd Off();
    }
}
