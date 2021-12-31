namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonUnpivotClauseAlias<
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin> :
        ICommonTableSelectionWithJoin<TTableSource, TPivotClause, TUnpivotClause>
    {
        TTableSelectionWithJoin As(TableAlias tableAlias);
    }

    public interface ICommonUnpivotClauseAlias<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin> :
        ICommonUnpivotClauseAlias<TTableSource, TPivotClause, TUnpivotClause, TTableSelectionWithJoin>
    {
    }
}
