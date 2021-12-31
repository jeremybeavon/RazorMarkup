namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithTableHint<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint> :
        ICommonTableSelectionWithTableHint<TTableSource, TPivotClause, TUnpivotClause, TTableHint>
    {
    }

    public interface ICommonTableSelectionWithTableHint<
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint> :
        ICommonTableSelectionWithJoin<TTableSource, TPivotClause, TUnpivotClause>
    {
        TTableHint WithHint();
    }
}
