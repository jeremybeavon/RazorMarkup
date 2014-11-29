namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupMasterKeyEncryption : IHideObjectMethods
    {
        ISqlString EncryptionByPassword(string password);
    }
}
