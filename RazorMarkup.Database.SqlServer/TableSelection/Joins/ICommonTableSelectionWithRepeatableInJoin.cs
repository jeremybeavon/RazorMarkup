namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonTableSelectionWithRepeatableInJoin<
        TJoinEndType,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSelectionWithTableHint> :
        ICommonTableSelectionWithRepeatable<
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSelectionWithTableHint>,
        IEndJoin<TJoinEndType>
    {
    }
}
