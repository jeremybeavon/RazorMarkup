namespace RazorMarkup.Database.SqlServer.Create.Login
{
    public interface ICreateLoginWithPasswordOption : IHideObjectMethods
    {
        ICreateLoginWithPasswordAnd Sid(string sid);

        ICreateLoginWithPasswordAnd DefaultDatabase(DatabaseName databaseName);

        ICreateLoginWithPasswordAnd DefaultLanguage(string language);

        ICreateLoginWithPasswordOptionOnOff CheckExpiration();

        ICreateLoginWithPasswordOptionOnOff CheckPolicy();

        ICreateLoginWithPasswordAnd Credential(CredentialName credentialName);
    }
}
