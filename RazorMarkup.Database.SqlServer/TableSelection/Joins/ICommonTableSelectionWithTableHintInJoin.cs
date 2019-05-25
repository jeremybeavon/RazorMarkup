namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonTableSelectionWithTableHintInJoin<
        TJoinEndType,
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint> : 
        ICommonTableSelectionWithTableHint<
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint>,
        IEndJoin<TJoinEndType>
    {
    }
}
