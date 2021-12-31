namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonPivotClauseAliasInJoin<
        TJoinEndType,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin> :
        ICommonPivotClauseAlias<TTableSource, TPivotClause, TUnpivotClause, TTableSelectionWithJoin>,
        IEndJoin<TJoinEndType>
    {
    }
}
