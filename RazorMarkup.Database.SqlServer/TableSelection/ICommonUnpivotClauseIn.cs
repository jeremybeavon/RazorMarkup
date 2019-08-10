namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonUnpivotClauseIn<TUnpivotClauseAlias> : IHideObjectMethods
    {
        TUnpivotClauseAlias In(params ColumnName[] columnNames);
    }
}
