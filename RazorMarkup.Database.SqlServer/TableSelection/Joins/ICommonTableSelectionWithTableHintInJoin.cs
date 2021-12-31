namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonTableSelectionWithTableHintInJoin<
        TJoinEndType,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint> :
        ICommonTableSelectionWithTableHint<
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint>,
        IEndJoin<TJoinEndType>
    {
    }
}
