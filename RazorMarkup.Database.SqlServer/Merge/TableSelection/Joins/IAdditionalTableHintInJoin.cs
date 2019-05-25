using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface IAdditionalTableHintInJoin<TJoinEndType> :
        IAdditionalCommonTableHint<
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            object,
            IDerivedTableWithAliasInJoin<TJoinEndType>,
            ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>>
    {
    }
}
