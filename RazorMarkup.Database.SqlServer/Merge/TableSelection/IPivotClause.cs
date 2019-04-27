namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface IPivotClause : IHideObjectMethods
    {
        IPivotClauseIn For(ColumnName columnName);
    }
}
