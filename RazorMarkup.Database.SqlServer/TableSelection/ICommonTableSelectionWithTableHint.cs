namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithTableHint<
        TTableSelectionInJoin, 
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint> :
        ICommonTableSelectionWithJoin<TTableSelectionInJoin, TTableSource, TPivotClause, TUnpivotClause>
    {
        TTableHint WithHint();
    }
}
