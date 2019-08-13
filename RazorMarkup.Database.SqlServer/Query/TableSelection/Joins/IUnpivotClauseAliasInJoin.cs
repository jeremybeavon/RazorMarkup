using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IUnpivotClauseAliasInJoin<TJoinEndType> :
        ICommonUnpivotClauseAlias<
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableSelectionWithJoinInJoin<TJoinEndType>>,
        ITableSelectionWithJoinInJoin<TJoinEndType>
    {
    }
}
