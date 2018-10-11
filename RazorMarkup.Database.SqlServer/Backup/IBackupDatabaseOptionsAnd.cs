namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseOptionsAnd<TOptions> : IHideObjectMethods, ISqlString
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        TOptions And();
    }
}
