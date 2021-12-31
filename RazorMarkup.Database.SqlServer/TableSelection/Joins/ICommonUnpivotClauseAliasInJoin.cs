namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonUnpivotClauseAliasInJoin<
        TJoinEndType,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin> :
        ICommonUnpivotClauseAlias<TTableSource, TPivotClause, TUnpivotClause, TTableSelectionWithJoin>,
        IEndJoin<TJoinEndType>
    {
    }
}
