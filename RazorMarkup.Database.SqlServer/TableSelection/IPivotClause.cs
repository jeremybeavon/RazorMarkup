namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface IPivotClause : IHideObjectMethods
    {
        IPivotClauseIn For(ColumnName columnName);
    }
}
