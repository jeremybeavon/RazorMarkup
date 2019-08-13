namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonPivotClauseAliasInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin> :
        ICommonPivotClauseAlias<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableSelectionWithJoin>,
        IEndJoin<TJoinEndType>
    {
    }
}
