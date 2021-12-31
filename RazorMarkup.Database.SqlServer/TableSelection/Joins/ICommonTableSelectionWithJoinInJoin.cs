namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ICommonTableSelectionWithJoinInJoin<
        TJoinEndType,
        TTableSource,
        TPivotClause,
        TUnpivotClause> :
        ICommonTableSelectionWithJoin<TTableSource, TPivotClause, TUnpivotClause>,
        IEndJoin<TJoinEndType>
    {
    }
}
