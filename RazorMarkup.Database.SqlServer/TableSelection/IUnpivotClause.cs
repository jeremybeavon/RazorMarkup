namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface IUnpivotClause : IHideObjectMethods
    {
        IUnpivotClauseIn For(ColumnName columnName);
    }
}
