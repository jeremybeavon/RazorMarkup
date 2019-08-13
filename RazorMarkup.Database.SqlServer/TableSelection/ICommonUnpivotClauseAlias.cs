namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonUnpivotClauseAlias<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin> :
        ICommonTableSelectionWithJoin<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause>
    {
        TTableSelectionWithJoin As(TableAlias tableAlias);
    }
}
