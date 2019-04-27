namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateCryptographicProviderStatement : IHideObjectMethods
    {
        ISqlString FromFile(string pathOfDll);
    }
}
