namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IPivotClause<TEndType> : IHideObjectMethods
    {
        IPivotClauseIn<TEndType> For(ColumnName columnName);
    }
}
