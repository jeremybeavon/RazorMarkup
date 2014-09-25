namespace RazorMarkup.Database.SqlServer.Restore
{
    public interface IRestoreServiceMasterKeyWithForce : IHideObjectMethods, ISqlString
    {
        ISqlString Force();
    }
}
