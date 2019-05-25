namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithAdditionalTableHint<
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TAdditionalTableHint> :
        ICommonTableSelectionWithJoin<TTableSelectionInJoin, TTableSource, TPivotClause, TUnpivotClause>
    {
        new TAdditionalTableHint And();
    }
}
