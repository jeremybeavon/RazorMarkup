namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface IUnpivotClause : IHideObjectMethods
    {
        IUnpivotClauseIn For(ColumnName columnName);
    }
}
