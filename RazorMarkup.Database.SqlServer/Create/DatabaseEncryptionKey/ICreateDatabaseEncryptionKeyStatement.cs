namespace RazorMarkup.Database.SqlServer.Create.DatabaseEncryptionKey
{
    public interface ICreateDatabaseEncryptionKeyStatement : IHideObjectMethods
    {
        ICreateDatabaseEncryptionKeyAlgorithm WithAlgorithm();
    }
}
