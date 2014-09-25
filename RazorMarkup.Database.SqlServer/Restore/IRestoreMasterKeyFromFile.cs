namespace RazorMarkup.Database.SqlServer.Restore
{
    public interface IRestoreMasterKeyFromFile : IHideObjectMethods
    {
        IRestoreMasterKeyDecryption FromFile(string pathToFile);
    }
}
