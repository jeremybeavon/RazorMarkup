using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Hints;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    public interface ITableSelectionWithTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintWithNoExpandInJoin<TJoinEndType> WithHint();
    }
}
