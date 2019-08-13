namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonTableSelectionWithRepeatableInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSelectionWithTableHint> :
        ICommonTableSelectionWithRepeatable<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSelectionWithTableHint>,
        IEndJoin<TJoinEndType>
    {
    }
}
