namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithTableSample<
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem> :
        ICommonTableSelectionWithTableHint<TTableSelectionInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint>
    {
        TTableSampleWithSystem TableSample();
    }
}
