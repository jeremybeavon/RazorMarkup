namespace RazorMarkup.Database.SqlServer.Restore
{
    public interface IRestoreMasterKeyEncryption : IHideObjectMethods
    {
        IRestoreMasterKeyWithForce EncryptionByPassword(string password);
    }
}
