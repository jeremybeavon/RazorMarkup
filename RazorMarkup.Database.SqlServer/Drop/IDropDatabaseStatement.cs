namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropDatabaseStatement : ISqlString, IHideObjectMethods
    {
        IDropDatabaseStatement And(DatabaseName databaseName);

        IDropDatabaseStatement And(DatabaseSnapshotName databaseSnapshotName);
    }
}
