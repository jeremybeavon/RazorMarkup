namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeTargetTable : IHideObjectMethods
    {
        object Table(TableName tableName);
    }
}
