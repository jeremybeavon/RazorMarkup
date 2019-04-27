namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface IUnpivotClauseIn : IHideObjectMethods
    {
        IUnpivotClauseAlias In(params ColumnName[] columnNames);
    }
}
