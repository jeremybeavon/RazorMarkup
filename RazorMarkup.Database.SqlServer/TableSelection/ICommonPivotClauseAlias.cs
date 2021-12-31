namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonPivotClauseAlias<
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin> :
        ICommonTableSelectionWithJoin<TTableSource, TPivotClause, TUnpivotClause>
    {
        TTableSelectionWithJoin As(TableAlias tableAlias);
    }

    public interface ICommonPivotClauseAlias<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin> :
        ICommonPivotClauseAlias<TTableSource, TPivotClause, TUnpivotClause, TTableSelectionWithJoin>
    {
    }
}
