using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface IAdditionalTableHintInJoin<TJoinEndType> :
        IAdditionalCommonTableHint<
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            ISubqueryWithAliasInJoin<TJoinEndType>,
            IDerivedTableWithAliasInJoin<TJoinEndType>,
            ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>>
    {
    }
}
