namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithAdditionalTableHint<
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TAdditionalTableHint> :
        ICommonTableSelectionWithJoin<TTableSource, TPivotClause, TUnpivotClause>
    {
        new TAdditionalTableHint And();
    }
}
