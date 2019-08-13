using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> :
        ICommonTableSelectionWithAdditionalTableHintInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            IAdditionalTableHintInJoin<TJoinEndType>>
    {
    }
}
