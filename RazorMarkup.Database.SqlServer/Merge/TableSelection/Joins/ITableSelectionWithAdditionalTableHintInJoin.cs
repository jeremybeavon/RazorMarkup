using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> :
        ICommonTableSelectionWithAdditionalTableHint<
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            IAdditionalTableHintInJoin<TJoinEndType>>
    {
    }
}
