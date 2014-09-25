namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropKeyStatement : ISqlString, IHideObjectMethods
    {
        ISqlString RemoveProviderKey();
    }
}
