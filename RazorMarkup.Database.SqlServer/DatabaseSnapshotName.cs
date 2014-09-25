namespace RazorMarkup.Database.SqlServer
{
    public sealed class DatabaseSnapshotName : SqlString
    {
        public DatabaseSnapshotName(string databaseSnapshotName)
            : base(databaseSnapshotName)
        {
        }
    }
}
