namespace RazorMarkup.Database.SqlServer.Create.DatabaseEncryptionKey
{
    public interface ICreateDatabaseEncryptionKeyEncryption
    {
        ISqlString Certificate(CertificateName certificateName);

        ISqlString AsymmetricKey(AsymmetricKeyName asymmetricKeyName);
    }
}
