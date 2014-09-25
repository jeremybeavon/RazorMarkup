namespace RazorMarkup.Database.SqlServer.Restore
{
    public interface IRestoreStatements : IHideObjectMethods
    {
        IRestoreMasterKeyFromFile MasterKey();

        IRestoreServiceMasterKeyFromFile ServiceMasterKey();
    }
}
