namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithTableHint<
        TTableSourceInJoin, 
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint> :
        ICommonTableSelectionWithJoin<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause>
    {
        TTableHint WithHint();
    }
}
