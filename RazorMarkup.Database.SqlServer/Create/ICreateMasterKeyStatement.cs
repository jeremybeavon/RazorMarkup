namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateMasterKeyStatement
    {
        ISqlString EncryptionByPassword(string password);
    }
}
