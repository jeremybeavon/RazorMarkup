namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonUnpivotClause<TUnpivotClauseIn> : IHideObjectMethods
    {
        TUnpivotClauseIn For(ColumnName columnName);
    }
}
