namespace RazorMarkup.Database.SqlServer.Create.DatabaseEncryptionKey
{
    public interface ICreateDatabaseEncryptionKeyEncryptionByServer : IHideObjectMethods
    {
        ICreateDatabaseEncryptionKeyEncryption EncryptionByServer();
    }
}
