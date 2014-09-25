namespace RazorMarkup.Database.SqlServer.Restore
{
    public interface IRestoreServiceMasterKeyDecryption : IHideObjectMethods
    {
        IRestoreServiceMasterKeyWithForce DecryptionByPassword(string password);
    }
}
