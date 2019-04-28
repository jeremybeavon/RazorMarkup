namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ITableSelectionWithTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintInJoin<TJoinEndType> WithHint();
    }
}
