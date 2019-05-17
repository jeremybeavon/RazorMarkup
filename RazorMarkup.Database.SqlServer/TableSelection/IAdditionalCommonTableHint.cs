namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface IAdditionalCommonTableHint<
        TTableSelectionWithAlias,
        TSubqueryWithAlias,
        TDerivedTableWithAlias,
        TTableSelectionWithAdditionalTableHint> :
        ICommonTableSource<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias>,
        ICommonTableHint<TTableSelectionWithAdditionalTableHint>
    {
    }
}
