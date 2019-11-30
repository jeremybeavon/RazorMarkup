namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeTargetTable : IHideObjectMethods
    {
        IMergeWithHint Table(TableName tableName);

        IMergeWithHint View(ViewName viewName);
    }
}
