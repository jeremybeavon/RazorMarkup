namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithAlias<
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TTableSelectionWithTableSample> :
        ICommonTableSelectionWithTableSample<TTableSelectionInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSampleWithSystem>
    {
        TTableSelectionWithTableSample As(TableAlias tableAlias);
    }
}
