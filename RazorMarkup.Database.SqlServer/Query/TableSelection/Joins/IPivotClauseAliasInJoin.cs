using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IPivotClauseAliasInJoin<TJoinEndType> :
        ICommonPivotClauseAliasInJoin<
            TJoinEndType,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSelectionWithJoinInJoin<TJoinEndType>
    {
    }
}
