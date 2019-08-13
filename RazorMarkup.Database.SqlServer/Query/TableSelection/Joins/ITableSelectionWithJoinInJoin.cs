using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithJoinInJoin<TJoinEndType> :
        ICommonTableSelectionWithJoinInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>>
    {
    }
}
