namespace RazorMarkup.Database.SqlServer.Restore
{
    public interface IRestoreMasterKeyDecryption : IHideObjectMethods
    {
        IRestoreMasterKeyEncryption DecryptionByPassword(string password);
    }
}
