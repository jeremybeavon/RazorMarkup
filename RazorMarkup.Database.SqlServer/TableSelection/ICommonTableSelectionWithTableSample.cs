namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithTableSample<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem> :
        ICommonTableSelectionWithTableHint<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint>
    {
        TTableSampleWithSystem TableSample();
    }
}
