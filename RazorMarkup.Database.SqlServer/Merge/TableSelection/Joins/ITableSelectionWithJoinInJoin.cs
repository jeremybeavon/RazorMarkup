using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableSelectionWithJoinInJoin<TJoinEndType> :
        ICommonTableSelectionWithJoinInJoin<
            TJoinEndType,
            ITableSelectionWithJoinInJoin<TJoinEndType>,
            ITableSourceInJoin<TJoinEndType>,
            object,
            object>
    {
    }
}
