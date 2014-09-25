namespace RazorMarkup.Database.SqlServer.Restore
{
    public interface IRestoreServiceMasterKeyFromFile : IHideObjectMethods
    {
        IRestoreServiceMasterKeyDecryption FromFile(string pathToFile);
    }
}
