namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonPivotClause<TPivotClauseIn> : IHideObjectMethods
    {
        TPivotClauseIn For(ColumnName columnName);
    }
}
