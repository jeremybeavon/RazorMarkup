namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonTableSelectionWithJoinInJoin<
        TJoinEndType,
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause> :
        ICommonTableSelectionWithJoin<TTableSelectionInJoin, TTableSource, TPivotClause, TUnpivotClause>,
        IEndJoin<TJoinEndType>
    {
    }
}
