using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableSelectionWithRepeatableInJoin<TJoinEndType> :
        ICommonTableSelectionWithRepeatableInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSelectionWithTableHintInJoin<TJoinEndType>>
    {
    }
}
