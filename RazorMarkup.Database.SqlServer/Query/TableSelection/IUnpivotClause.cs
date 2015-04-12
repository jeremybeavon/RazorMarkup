namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IUnpivotClause<TEndType> : IHideObjectMethods
    {
        IUnpivotClauseIn<TEndType> For(ColumnName columnName);
    }
}
