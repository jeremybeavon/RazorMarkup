using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IAdditionalTableHintInJoin<TEndType> :
        IAdditionalCommonTableHint<
            ITableSelectionWithAliasInJoin<TEndType>,
            ISubqueryWithAliasInJoin<TEndType>,
            IDerivedTableWithAliasInJoin<TEndType>,
            ITableSelectionWithAdditionalTableHintInJoin<TEndType>>
    {
    }
}
