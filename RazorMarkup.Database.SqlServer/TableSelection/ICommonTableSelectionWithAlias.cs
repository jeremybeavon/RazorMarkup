namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithAlias<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TTableSelectionWithTableSample> :
        ICommonTableSelectionWithTableSample<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSampleWithSystem>
    {
        TTableSelectionWithTableSample As(TableAlias tableAlias);
    }
}
