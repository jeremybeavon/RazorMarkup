namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface IUnpivotClauseIn : IHideObjectMethods
    {
        IUnpivotClauseAlias In(params ColumnName[] columnNames);
    }
}
