namespace RazorMarkup.Database.SqlServer.Create.User
{
    public interface ICreateUserForOrFromOption
    {
        ICreateUserWithDefaultSchema Login(LoginName loginName);

        ISqlString Certificate(CertificateName certificateName);

        ISqlString AsymmetricKey(AsymmetricKeyName asymmetricKeyName);
    }
}
