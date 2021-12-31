namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonTableSelectionWithAliasInJoin<
        TJoinEndType,
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
            TTableSelectionWithTableSample>,
        IEndJoin<TJoinEndType>
    {
    }
}
