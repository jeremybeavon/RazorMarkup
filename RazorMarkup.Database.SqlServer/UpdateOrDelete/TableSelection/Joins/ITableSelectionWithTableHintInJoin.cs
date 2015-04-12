namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    public interface ITableSelectionWithTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintInJoin<TJoinEndType> WithHint();
    }
}
