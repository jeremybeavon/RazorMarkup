namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupServiceMasterKeyEncryption : IHideObjectMethods
    {
        ISqlString EncryptionByPassword(string password);
    }
}
