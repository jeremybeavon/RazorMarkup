namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithTableSample<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem> :
        ICommonTableSelectionWithTableSample<TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSampleWithSystem>
    {
    }

    public interface ICommonTableSelectionWithTableSample<
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem> :
        ICommonTableSelectionWithTableHint<TTableSource, TPivotClause, TUnpivotClause, TTableHint>
    {
        TTableSampleWithSystem TableSample();
    }
}
