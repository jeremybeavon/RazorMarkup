using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithRepeatableInJoin<TJoinEndType> :
        ICommonTableSelectionWithRepeatableInJoin<
            TJoinEndType,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSelectionWithTableHintInJoin<TJoinEndType>>,
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
    }
}
