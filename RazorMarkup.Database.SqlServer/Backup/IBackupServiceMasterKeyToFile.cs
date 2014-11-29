namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupServiceMasterKeyToFile : IHideObjectMethods
    {
        IBackupServiceMasterKeyEncryption ToFile(string pathToFile);
    }
}
