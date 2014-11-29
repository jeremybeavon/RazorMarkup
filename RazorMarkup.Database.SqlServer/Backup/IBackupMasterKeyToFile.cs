namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupMasterKeyToFile : IHideObjectMethods
    {
        IBackupMasterKeyEncryption ToFile(string pathToFile);
    }
}
