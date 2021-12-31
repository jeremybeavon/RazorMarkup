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
        ICommonTableSelectionWithAlias<
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem,
            TTableSelectionWithTableSample>
    {
    }

    public interface ICommonTableSelectionWithAlias<
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TTableSelectionWithTableSample> :
        ICommonTableSelectionWithTableSample<
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem>
    {
        TTableSelectionWithTableSample As(TableAlias tableAlias);
    }
}
