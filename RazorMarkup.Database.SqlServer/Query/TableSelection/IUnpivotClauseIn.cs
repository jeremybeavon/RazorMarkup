namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IUnpivotClauseIn<TEndType> : IHideObjectMethods
    {
        IUnpivotClauseAlias<TEndType> In(params ColumnName[] columnNames);
    }
}
