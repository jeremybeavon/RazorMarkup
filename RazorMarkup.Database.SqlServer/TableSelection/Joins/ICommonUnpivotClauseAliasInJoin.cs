namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonUnpivotClauseAliasInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin> :
        ICommonUnpivotClauseAlias<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableSelectionWithJoin>,
        IEndJoin<TJoinEndType>
    {
    }
}
