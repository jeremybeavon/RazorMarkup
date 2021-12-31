namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonTableSelectionWithAdditionalTableHintInJoin<
        TJoinEndType,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TAdditionalTableHint> :
        ICommonTableSelectionWithAdditionalTableHint<
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TAdditionalTableHint>,
        IEndJoin<TJoinEndType>
    {
    }
}
