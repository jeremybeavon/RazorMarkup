namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeNotMatched : IHideObjectMethods
    {
        IMergeNotMatchedInsert Insert(params ColumnName[] columnNames);
    }
}
