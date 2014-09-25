namespace RazorMarkup.Database.SqlServer.Restore
{
    public interface IRestoreMasterKeyWithForce : IHideObjectMethods, ISqlString
    {
        ISqlString Force();
    }
}
