using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Hints;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintWithNoExpandInJoin<TJoinEndType> WithHint();
    }
}
