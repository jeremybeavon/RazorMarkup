namespace RazorMarkup.Database.SqlServer.Create.Login
{
    public interface ICreateLoginFrom : IHideObjectMethods
    {
        ICreateLoginFromWindowsWith Windows();

        ISqlString Certificate(CertificateName certificateName);

        ISqlString AsymmetricKey(AsymmetricKeyName asymmetricKeyName);
    }
}
