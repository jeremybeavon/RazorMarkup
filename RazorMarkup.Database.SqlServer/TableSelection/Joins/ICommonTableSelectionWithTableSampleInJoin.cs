namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonTableSelectionWithTableSampleInJoin<
        TJoinEndType,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem> :
        ICommonTableSelectionWithTableSample<
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem>,
        IEndJoin<TJoinEndType>
    {
    }
}
