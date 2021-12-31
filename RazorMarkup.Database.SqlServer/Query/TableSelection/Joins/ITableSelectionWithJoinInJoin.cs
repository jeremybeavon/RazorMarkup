using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithJoinInJoin<TJoinEndType> :
        //ICommonTableSelectionWithTableSourceInJoin<ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>>,
        ICommonTableSelectionWithJoinInJoin<
            TJoinEndType,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>>
    {
    }
}
