namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseOptionsAnd<TOptions> : IHideObjectMethods, ISqlString
    {
        TOptions And();
    }
}
